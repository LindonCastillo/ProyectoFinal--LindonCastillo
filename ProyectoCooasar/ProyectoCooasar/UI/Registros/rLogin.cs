using ProyectoCooasar.BLL;
using ProyectoCooasar.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCooasar.UI.Registros
{
    public partial class rLogin : Form
    {

        public rLogin()
        {
            InitializeComponent();
        }

        private void Restaurar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar_pictureBox.Visible = false;
            Maximixar_pictureBox.Visible = true;
        }

        private void Cerrar_pictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximixar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximixar_pictureBox.Visible = false;
            Restaurar_pictureBox.Visible = true;
        }

        private void Minimizar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);


        private void Limpiar_button_Click(object sender, EventArgs e)
        {
            Usuario_textBox.Text = string.Empty;
            Clave_textBox.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            bool paso = true;

            if(string.IsNullOrWhiteSpace(Usuario_textBox.Text))
            {
                ErrorProvider.SetError(Usuario_textBox, "El campo Usuario no puede estar vacío");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Clave_textBox.Text))
            {
                ErrorProvider.SetError(Clave_textBox, "El campo Clave no puede estar vacío");
                paso = false;
            }

            return paso;
        }

        private bool ValidarLogin()
        {
            bool paso = false;

            if(Usuario_textBox.Text =="Admin" && Clave_textBox.Text == "12345")
            {
                paso = true;
            }
            else
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
                var listado = new List<Usuarios>();
                listado = repositorio.GetList(p => true);
                foreach (var item in listado)
                {
                    if(Usuario_textBox.Text == item.Nombre && Clave_textBox.Text == item.Clave) { }
                }
            }

            return paso;
        }
        private void IniciarSesion_button_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (!ValidarLogin())
            {
                MessageBox.Show("Usuaio No valido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dispose();
        }
         
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
