using Entidades;
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
            this.Detalles = new List<ComprasDetalle>();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            CompraId_numericUpDown.Value = 0;
            Fecha_dateTimePicker.Value = DateTime.Now;
            Itbis_numericUpDown.Value = 0;
            ProveedorId_numericUpDown.Value = 0;
            Proveedor_textBox.Text = string.Empty;

            this.Detalle = new List<ComprasDetalle>();
            CargarGrid();
        }

        private bool Validar()
        {
            ErrorProvider.Clear();
            bool paso = true;
            if (string.IsNullOrEmpty(Proveedor_textBox.Text))
            {
                ErrorProvider.SetError(Proveedor_textBox, "El campo Proveedor no puede estar vacío");
                paso = false;
            }

            if (string.IsNullOrEmpty(Producto_textBox.Text))
            {
                ErrorProvider.SetError(Producto_textBox, "El campo Producto no puede estar vacío");
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
        private void CargarGrid()
        {
            Detalle_dataGridView.DataSource = null;
            Detalle_dataGridView.DataSource = this.Detalle;
        }

        public decimal CalculoMonto()
        {
            decimal monto = 0;

            foreach (var item in Detalle)
            {
                monto += item.Subtotal;
            }

            return monto;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {

        }

        private void BuscarProducto_button_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {

        }

        private void Remover_button_Click(object sender, EventArgs e)
        {
            if (Detalle_dataGridView.Rows.Count > 0 && Detalle_dataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(Detalle_dataGridView.CurrentRow.Index);
                CargarGrid();
                Balance_textBox.Text = CalculoMonto().ToString();
            }
    }
}
