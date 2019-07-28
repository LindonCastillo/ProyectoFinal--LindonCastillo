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

        public int IdUsuario;
        public rPagos(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
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
            if (string.IsNullOrWhiteSpace(Balance_textBox.Text))
            {
                ErrorProvider.SetError(Balance_textBox, "Busque una Compra");
                paso = false;
            }

            if (CompraId_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(CompraId_numericUpDown, "El valor de este campo no puede ser cero");
                paso = false;
            }

            bool paso2 = ValidarCompra();
            if (paso2 == false)
            {
                ErrorProvider.SetError(CompraId_numericUpDown, "La Compra que intento buscar no exíste");
                paso = false;
            }

            if (Efectivo_radioButton.Checked == false && Cheque_radioButton.Checked == false)
            {
                ErrorProvider.SetError(Cheque_radioButton, "Elija una forma de pago");
                paso = false;
            }

            if(Pago_numericUpDown.Value == 0)
            {
                ErrorProvider.SetError(Pago_numericUpDown, "El pago no puede ser cero");
                paso = false;
            }


            return paso;
        }

        private Pagos LlenarClase()
        {
            Pagos pagos = new Pagos();
            pagos.PagoId = (int)PagoId_numericUpDown.Value;
            pagos.Fecha = Fecha_dateTimePicker.Value;
            pagos.PagoTotal = CalculoPagoTotal();
            pagos.UsuarioId = IdUsuario;

            pagos.DetallePagos = this.Detalle;

            return pagos;
        }


        private void LlenarCampos(Pagos pagos)
        {
            PagoId_numericUpDown.Value = pagos.PagoId;
            Fecha_dateTimePicker.Value = pagos.Fecha;
            PagaTotal_textBox.Text = pagos.PagoTotal.ToString();

            this.Detalle = pagos.DetallePagos;
            CargarGrid();
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            Pagos Pago = PagosBLL.Buscar((int)PagoId_numericUpDown.Value);
            return (Pago != null);
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarDetalle();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Pagos pagos;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            pagos = LlenarClase();

            if (PagoId_numericUpDown.Value == 0)
            {
                paso = PagosBLL.Guardar(pagos);
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
                    MessageBox.Show("No se puede Modificar un pago que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = PagosBLL.Modificar(pagos);
                Limpiar();
                MessageBox.Show("Se modifico con Exito!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Recontar(Pagos pagos)
        { 
            foreach (var item in pagos.DetallePagos)
            {
                var compraId = item.CompraId;
                Compras compra = ComprasBLL.Buscar(compraId);

                compra.Balance += item.Pago;
                ComprasBLL.Modificar(compra);
            }
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            int id;
            int.TryParse(PagoId_numericUpDown.Text, out id);
            Pagos Pago = PagosBLL.Buscar(id);
            
            try
            {
                if (PagosBLL.Eliminar(id))
                {
                    Recontar(Pago);
                    Limpiar();
                    MessageBox.Show("Eliminado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar este Pago", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            Pagos Pago;
            int id = Convert.ToInt32(PagoId_numericUpDown.Value);

            Limpiar();
            try
            {
                Pago = PagosBLL.Buscar(id);
                if (Pago != null)
                {
                    LlenarCampos(Pago);
                    MessageBox.Show("Pago Encontrado!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Pago No Encontrado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            { 
                MessageBox.Show("No se pudo buscar");

            }
        }

        private void BuscarCompraId_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CompraId_numericUpDown.Value != 0)
                {

                    Compras compras = ComprasBLL.Buscar((int)CompraId_numericUpDown.Value);
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
            if (!Validar2())
            {
                return;
            }

            if (Detalle.Any(A => A.CompraId == CompraId_numericUpDown.Value))
            {
                MessageBox.Show("Ya se agrego un pago a esa la compra previamente", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tipopago = string.Empty;
            if (Cheque_radioButton.Checked == true)
                tipopago = "Cheque";

            if (Efectivo_radioButton.Checked == true)
                tipopago = "Efectivo";

            try
            {
                if (Detalle_dataGridView.DataSource != null)
                    this.Detalle = (List<PagosDetalle>)Detalle_dataGridView.DataSource;

                this.Detalle.Add(
                    new PagosDetalle(
                        Id: 0,
                        PagoId: (int)PagoId_numericUpDown.Value,
                        CompraId: (int)CompraId_numericUpDown.Value,
                        TipoPaga: tipopago,
                        Pago: (int)Pago_numericUpDown.Value
                        )
                    );
                CargarGrid();
                LimpiarDetalle();

                MostrarBalance();
                PagaTotal_textBox.Text = CalculoPagoTotal().ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Producto no encontrado");
                LimpiarDetalle();
            }
        }

        private void LimpiarDetalle()
        {
            Efectivo_radioButton.Checked = false;
            Cheque_radioButton.Checked = false;
            Pago_numericUpDown.Value = 0;
        }

        private void Remover_button_Click(object sender, EventArgs e)
        {
            if (Detalle_dataGridView.Rows.Count > 0 && Detalle_dataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(Detalle_dataGridView.CurrentRow.Index);
                CargarGrid();
                PagaTotal_textBox.Text = CalculoPagoTotal().ToString();
            }
        }
        private decimal CalculoPagoTotal()
        {
            decimal PagoTotal = 0;

            foreach (var item in Detalle)
            {
                PagoTotal += item.Pago;
            }

            return PagoTotal;
        }

        private void MostrarBalance()
        {
            Compras compras = ComprasBLL.Buscar((int)CompraId_numericUpDown.Value);
            Balance_textBox.Text = compras.Balance.ToString();
        }


        private void CargarGrid()
        {
            Detalle_dataGridView.DataSource = null;
            Detalle_dataGridView.DataSource = this.Detalle;
        }
    }
}
