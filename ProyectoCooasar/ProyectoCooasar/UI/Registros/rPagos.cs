using BLL;
using Entidades;
using ProyectoCooasar.DAL;
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
    public partial class rPagos : Form
    {
        public List<PagosDetalle> Detalle { get; set; }
        public rPagos()
        {
            InitializeComponent();
            this.Detalle = new List<PagosDetalle>();
        }
        private void Limpiar()
        {
            ErrorProvider.Clear();
            PagoId_numericUpDown.Value = 0;
            CompraId_numericUpDown.Value = 0;
            Fecha_dateTimePicker.Value = DateTime.Now;
            Balance_textBox.Text = string.Empty;
            Cheque_radioButton.Checked = false;
            Efectivo_radioButton.Checked = false;
            PagoId_numericUpDown.Value = 0;
            PagaTotal_textBox.Text = string.Empty;

            this.Detalle = new List<PagosDetalle>();
            CargarGrid();
        }

        private bool ValidarCompra()
        {
            bool existe;
            Compras compras = new Compras();
            Contexto db = new Contexto();
            compras = db.Compra.Find((int)CompraId_numericUpDown.Value);

            if (compras != null)
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
            if (CompraId_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(CompraId_numericUpDown, "Elija un Proveedor por el Id");
                paso = false;
            }

            bool paso2 = ValidarCompra();
            if (paso2 == false)
            {
                ErrorProvider.SetError(CompraId_numericUpDown, "La Compra que intento buscar no exíste");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Balance_textBox.Text))
            {
                ErrorProvider.SetError(Balance_textBox, "Busque una Compra");
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                ErrorProvider.SetError(Detalle_dataGridView, "Debe agregar algún Pago");
                paso = false;
            }

            return paso;
        }

        private bool Validar2()
        {
            ErrorProvider.Clear();
            bool paso = true;


            if (Efectivo_radioButton.Checked == false && Cheque_radioButton.Checked == false)
            {
                ErrorProvider.SetError(Cheque_radioButton, "Elija una forma de pago");
                paso = false;
            }

            if (PagoId_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(PagoId_numericUpDown, "El valor de este campo no puede ser cero");
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

        private void BuscarCompraId_button_Click(object sender, EventArgs e)
        {
            Compras compras;

            try
            {
                if (CompraId_numericUpDown.Value != 0)
                {
                    compras = ComprasBLL.Buscar((int)CompraId_numericUpDown.Value);
                    Balance_textBox.Text = compras.Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Debe poner un Id Para buscar a una compra");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Compra no encontrada");
                Balance_textBox.Text = string.Empty;
            }
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {

        }

        private void Remover_button_Click(object sender, EventArgs e)
        {

        }
        private decimal CalculoBalance()
        {
            decimal Balance = 0;

            foreach (var item in Detalle)
            {
                Balance += item.Pago;
            }

            return Balance;
        }
        private void CargarGrid()
        {
            Detalle_dataGridView.DataSource = null;
            Detalle_dataGridView.DataSource = this.Detalle;
        }
    }
}
