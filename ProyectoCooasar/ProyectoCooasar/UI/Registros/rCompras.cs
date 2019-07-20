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
        public List<ComprasDetalle> Detalles { get; set; }
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
            NFC_textBox.Text;

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

            if (PrecioVenta_numericUpDown.Value <= PrecioCompra_numericUpDown.Value)
            {
                ErrorProvider.SetError(PrecioVenta_numericUpDown, "El precio de venta tienen que ser mayor al de compra");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Nombre_textBox.Text))
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

    }
}
