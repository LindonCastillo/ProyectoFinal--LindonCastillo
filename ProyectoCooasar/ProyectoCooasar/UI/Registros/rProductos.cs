using ProyectoCooasar.BLL;
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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            ProductoId_numericUpDown.Value = 0;
            Nombre_textBox.Text = string.Empty;
            Fecha_dateTimePicker.Value = DateTime.Now;
            Cantidad_numericUpDown.Value = 0;
            PrecioCompra_numericUpDown.Value = 0;
            PrecioVenta_numericUpDown.Value = 0;
            ITBIS_numericUpDown.Value = 0;
        }

        private bool Validar()
        {
            ErrorProvider.Clear();
            bool paso = true;
            if (PrecioVenta_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(PrecioVenta_numericUpDown, "El valor de este campo no puede ser cero");
                paso = false;
            }

            if (PrecioCompra_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(PrecioCompra_numericUpDown, "El valor de este campo no puede ser cero");
                paso = false;
            }

            if(PrecioVenta_numericUpDown.Value <= PrecioCompra_numericUpDown.Value)
            {
                ErrorProvider.SetError(PrecioVenta_numericUpDown, "El precio de venta tienen que ser mayor al de compra");
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(Nombre_textBox.Text))
            {
                ErrorProvider.SetError(Nombre_textBox, "El campo Nombre no puede estar vacío");
                paso = false;
            }

            decimal Prueba = 0;
            if (decimal.TryParse(Nombre_textBox.Text, out Prueba))
            {
                ErrorProvider.SetError(Nombre_textBox, "El campo Nombre no pueden ser números");
                paso = false;
            }

            return paso;
        }

        private Productos LlenarClase()
        {
            Productos p = new Productos();
            p.ProductoId = (int)ProductoId_numericUpDown.Value;
            p.Nombre = Nombre_textBox.Text.Trim();
            p.Fecha = Fecha_dateTimePicker.Value;
            p.Cantidad = (int)Cantidad_numericUpDown.Value;
            p.PrecioCompra = PrecioCompra_numericUpDown.Value;
            p.PrecioVenta = PrecioVenta_numericUpDown.Value;
            p.ITBIS = (int)ITBIS_numericUpDown.Value;

            return p;
        }

        private void LlenarCampos(Productos producto)
        {
            ProductoId_numericUpDown.Value = producto.ProductoId;
            Nombre_textBox.Text = producto.Nombre;
            Fecha_dateTimePicker.Value = producto.Fecha;
            Cantidad_numericUpDown.Value = producto.Cantidad;
            PrecioCompra_numericUpDown.Value = producto.PrecioCompra;
            PrecioVenta_numericUpDown.Value = producto.PrecioVenta;
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos Producto = repositorio.Buscar((int)ProductoId_numericUpDown.Value);
            return (Producto != null);
        }


        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos Producto;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            Producto = LlenarClase();

            if (ProductoId_numericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(Producto);

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
                    MessageBox.Show("No se puede Modificar un producto que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(Producto);
                Limpiar();
                MessageBox.Show("Se modifico con Exito!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            int id = Convert.ToInt32(ProductoId_numericUpDown.Value);
            ErrorProvider.Clear();

            Limpiar();
            try
            {
                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar este usuario", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar!");
            }
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos;
            int id = Convert.ToInt32(ProductoId_numericUpDown.Value);

            Limpiar();
            try
            {
                productos = repositorio.Buscar(id);

                if (productos != null)
                {
                    LlenarCampos(productos);
                    MessageBox.Show("Producto Encontrado!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto No Encontrado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar!");
            }
        }
    }
}
