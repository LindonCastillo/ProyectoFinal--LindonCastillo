using Entidades;
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
    public partial class rProveedores : Form
    {
        public rProveedores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            ProveedorId_numericUpDown.Value = 0;
            Nombre_textBox.Text = string.Empty;
            Fecha_dateTimePicker.Value = DateTime.Now;
            RNC_textBox.Text = string.Empty;
            Telefono_maskedTextBox.Text = string.Empty;
            Direcccion_textBox.Text = string.Empty;
            Bienes_checkBox.Checked = false;
            Servicios_checkBox.Checked = false;
            Pesos_radioButton.Checked = false;
            Dolar_radioButton.Checked = false;
        }

        private bool Validar()
        {
            ErrorProvider.Clear();
            bool paso = true;

            if(Pesos_radioButton.Checked == false && Dolar_radioButton.Checked == false)
            {
                ErrorProvider.SetError(Dolar_radioButton, "Tiene que seleccionar una opción");
                paso = false;
            }

            if (Bienes_checkBox.Checked == false && Servicios_checkBox.Checked == false)
            {
                ErrorProvider.SetError(Servicios_checkBox, "Tiene que seleccionar una opción");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Nombre_textBox.Text))
            {
                ErrorProvider.SetError(Nombre_textBox, "El campo Nombre no puede estar vacío");
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(Direcccion_textBox.Text))
            {
                ErrorProvider.SetError(Direcccion_textBox, "El campo Direcccion no puede estar vacío");
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(Telefono_maskedTextBox.Text.Replace("-","")))
            {
                ErrorProvider.SetError(Telefono_maskedTextBox, "El campo Telefono no puede estar vacío");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(RNC_textBox.Text))
            {
                ErrorProvider.SetError(RNC_textBox, "El campo RNC no puede estar vacío");
                paso = false;
            }

            return paso;
        }

        private Proveedores LlenarClase()
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ProveedorId = Convert.ToInt32(ProveedorId_numericUpDown.Value);
            proveedores.Nombre = Nombre_textBox.Text.Trim();
            proveedores.Fecha = Fecha_dateTimePicker.Value;
            proveedores.Telefono = Telefono_maskedTextBox.Text;
            proveedores.RNC = RNC_textBox.Text.Trim();
            proveedores.Direccion = Direcccion_textBox.Text.Trim();
            if(Bienes_checkBox.Checked == true)
            {
                proveedores.Tipo = "Bienes";
            }

            if(Servicios_checkBox.Checked == true)
            {
                proveedores.Tipo = "Servicios";
            }

            if(Bienes_checkBox.Checked == true && Servicios_checkBox.Checked == true)
            {
                proveedores.Tipo = "Bienes y Servicios";
            }

            if(Pesos_radioButton.Checked == true)
            {
                proveedores.TipoMoneda = "Pesos";
            }

            if(Dolar_radioButton.Checked == true)
            {
                proveedores.TipoMoneda = "Dolar";
            }

            return proveedores;
        }

        private void LlenarCampos(Proveedores Proveedor)
        {
            ProveedorId_numericUpDown.Value = Proveedor.ProveedorId;
            Fecha_dateTimePicker.Value = Proveedor.Fecha;
            Nombre_textBox.Text = Proveedor.Nombre;
            Telefono_maskedTextBox.Text = Proveedor.Telefono;
            RNC_textBox.Text = Proveedor.RNC;
            Direcccion_textBox.Text = Proveedor.Direccion;
            if(Proveedor.Tipo == "Bienes")
            {
                Bienes_checkBox.Checked = true;
            }

            if(Proveedor.Tipo == "Servicios")
            {
                Servicios_checkBox.Checked = true;
                
            }

            if(Proveedor.Tipo == "Bienes y Servicios")
            {
                Bienes_checkBox.Checked = true;
                Servicios_checkBox.Checked = true;
            }

            if (Proveedor.TipoMoneda == "Pesos")
            {
                Pesos_radioButton.Checked = true;
            }

            if (Proveedor.TipoMoneda == "Dolar")
            {
                Dolar_radioButton.Checked = true;
            }
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            Proveedores proveedor = repositorio.Buscar((int)ProveedorId_numericUpDown.Value);
            return (proveedor != null);
        }


        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            Proveedores proveedores;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            proveedores = LlenarClase();

            if (ProveedorId_numericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(proveedores);

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
                    MessageBox.Show("No se puede Modificar un proveedor que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(proveedores);
                Limpiar();
                MessageBox.Show("Se modifico con Exito!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            int id = Convert.ToInt32(ProveedorId_numericUpDown.Value);
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
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            Proveedores proveedores;
            int id = Convert.ToInt32(ProveedorId_numericUpDown.Value);

            Limpiar();
            try
            {
                proveedores = repositorio.Buscar(id);

                if (proveedores != null)
                {
                    LlenarCampos(proveedores);
                    MessageBox.Show("Proveedor Encontrado!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Proveedor No Encontrado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar!");
            }
        }
    }
}
