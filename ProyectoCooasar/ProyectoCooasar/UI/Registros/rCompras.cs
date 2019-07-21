using BLL;
using Entidades;
using ProyectoCooasar.BLL;
using ProyectoCooasar.DAL;
using ProyectoCooasar.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCooasar.UI.Registros
{
    public partial class rCompras : Form
    {
        public List<ComprasDetalle> Detalle { get; set; }
        public rCompras()
        {
            InitializeComponent();
            this.Detalle = new List<ComprasDetalle>();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            CompraId_numericUpDown.Value = 0;
            Fecha_dateTimePicker.Value = DateTime.Now;
            Itbis_numericUpDown.Value = 0;
            ProveedorId_numericUpDown.Value = 0;
            Proveedor_textBox.Text = string.Empty;
            ProductoId_numericUpDown.Value = 0;
            Producto_textBox.Text = string.Empty;
            Balance_textBox.Text = string.Empty;

            this.Detalle = new List<ComprasDetalle>();
            CargarGrid();
        }

        private bool ValidarProveedor()
        {
            bool existe;
            Proveedores proveedores = new Proveedores();
            Contexto db = new Contexto();
            proveedores = db.Proveedor.Find((int)ProveedorId_numericUpDown.Value);
            
            if(proveedores != null)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }

            return existe;
        }

        private bool Validar()
        {
            ErrorProvider.Clear();
            bool paso = true;
            if (ProveedorId_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(ProveedorId_numericUpDown, "Elija un Proveedor por el Id");
                paso = false;
            }

            bool paso2 = ValidarProveedor();
            if(paso2 == false)
            {
                ErrorProvider.SetError(ProveedorId_numericUpDown, "El Proveedor que intento buscar no exíste");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Proveedor_textBox.Text))
            {
                ErrorProvider.SetError(Proveedor_textBox, "Busque un Proveedor");
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                ErrorProvider.SetError(Detalle_dataGridView, "Debe agregar algún Producto");
                paso = false;
            }

            return paso;
        }

        private bool Validar2()
        {
            ErrorProvider.Clear();
            bool paso = true;


            if (ProductoId_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(ProductoId_numericUpDown, "Elija un producto por el Id");
                paso = false;
            }

            if (Cantidad_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(Cantidad_numericUpDown, "El valor de este campo no puede ser cero");
                paso = false;
            }

            return paso;
        }

        private Compras LlenarClase()
        {
            Compras compras = new Compras();
            compras.CompraId = (int)CompraId_numericUpDown.Value;
            compras.Fecha = Fecha_dateTimePicker.Value;
            compras.Itbis = (int)Itbis_numericUpDown.Value;
            compras.ProveedorId = (int)ProveedorId_numericUpDown.Value;
            compras.Balance = CalculoBalance();

            compras.DetalleCompra = this.Detalle;

            return compras;
        }


        private void LlenarCampos(Compras Compra)
        {
            CompraId_numericUpDown.Value = Compra.CompraId;
            Fecha_dateTimePicker.Value = Compra.Fecha;
            Itbis_numericUpDown.Value = Compra.Itbis;
            ProveedorId_numericUpDown.Value = Compra.ProveedorId;

            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            Proveedores Proveedor;
            Proveedor = repositorio.Buscar(Compra.ProveedorId);
            Proveedor_textBox.Text = Proveedor.Nombre;

            Balance_textBox.Text = Compra.Balance.ToString();

            this.Detalle = Compra.DetalleCompra;
            CargarGrid();
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            Compras Compra = ComprasBLL.Buscar((int)CompraId_numericUpDown.Value);
            return (Compra != null);
        }

        private void CargarGrid()
        {
            Detalle_dataGridView.DataSource = null;
            Detalle_dataGridView.DataSource = this.Detalle;
        }

        private decimal CalculoBalance()
        {
            decimal Balance = 0;

            foreach (var item in Detalle)
            {
                Balance += item.Subtotal;
            }

            return Balance;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Compras Compra;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            Compra = LlenarClase();

            if (CompraId_numericUpDown.Value == 0)
            {
                paso = ComprasBLL.Guardar(Compra);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible guardar!!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar una Compra que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = ComprasBLL.Modificar(Compra);
                Limpiar();
                MessageBox.Show("Se modifico con Exito!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            int id;
            int.TryParse(CompraId_numericUpDown.Text, out id);

            try
            {
                if (ComprasBLL.Eliminar(id))
                {
                    Limpiar();
                    MessageBox.Show("Eliminado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta Compra", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            Compras Compra;
            int id = Convert.ToInt32(CompraId_numericUpDown.Value);

            Limpiar();
            try
            {
                Compra = ComprasBLL.Buscar(id);
                if (Compra != null)
                {
                    LlenarCampos(Compra);
                    MessageBox.Show("Compra Encontrada!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else
                {
                    MessageBox.Show("Compra No Encontrada!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar");
                
            }
        }

        private void BuscarProducto_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos Producto;

            try
            {
                if (ProductoId_numericUpDown.Value != 0)
                {
                    Producto = repositorio.Buscar((int)ProductoId_numericUpDown.Value);
                    Producto_textBox.Text = Producto.Nombre;
                }
                else
                {
                    MessageBox.Show("Debe poner un Id Para buscar a un producto");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void LimpiarDetalle()
        {
            ProductoId_numericUpDown.Value = 0;
            Producto_textBox.Clear();
            Cantidad_numericUpDown.Value = 0;
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            if (!Validar2())
            {
                return;
            }

            if (Detalle.Any(A => A.ProductoId == ProductoId_numericUpDown.Value))
            {
                MessageBox.Show("Este producto ya esta en la compra", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var busqueda = repositorio.Buscar((int)ProductoId_numericUpDown.Value);

            try
            {
                if (Detalle_dataGridView.DataSource != null)
                    this.Detalle = (List<ComprasDetalle>)Detalle_dataGridView.DataSource;

                this.Detalle.Add(
                    new ComprasDetalle(
                        Id: 0,
                        CompraId: (int)CompraId_numericUpDown.Value,
                        Cantidad: (int)Cantidad_numericUpDown.Value,
                        ProductoId: (int)ProductoId_numericUpDown.Value,
                        Precio: busqueda.PrecioCompra,
                        Subtotal: Cantidad_numericUpDown.Value * busqueda.PrecioCompra
                        )
                    );
                CargarGrid();
                ProductoId_numericUpDown.Focus();
                LimpiarDetalle();

                Balance_textBox.Text = CalculoBalance().ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Producto no encontrado");
                LimpiarDetalle();
            }
        }

        private void Remover_button_Click(object sender, EventArgs e)
        {
            if (Detalle_dataGridView.Rows.Count > 0 && Detalle_dataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(Detalle_dataGridView.CurrentRow.Index);
                CargarGrid();
                Balance_textBox.Text = CalculoBalance().ToString();
            }
        }

        private void BuscarProveedor_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            Proveedores Proveedor;

            try
            {
                if (ProveedorId_numericUpDown.Value != 0)
                {
                    Proveedor = repositorio.Buscar((int)ProveedorId_numericUpDown.Value);
                    Proveedor_textBox.Text = Proveedor.Nombre;
                }
                else
                {
                    MessageBox.Show("Debe poner un Id Para buscar a un proveedor");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Proveedor no encontrado");
                Proveedor_textBox.Text = string.Empty;
            }
        }
    }
}
