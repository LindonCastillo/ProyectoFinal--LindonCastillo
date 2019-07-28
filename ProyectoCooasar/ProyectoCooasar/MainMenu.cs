using ProyectoCooasar.BLL;
using ProyectoCooasar.Entidades;
using ProyectoCooasar.UI.Consultas;
using ProyectoCooasar.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCooasar
{
    public partial class MainMenu : Form
    {
        public int IdUsuario;
        public MainMenu(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
            MostrarUsuario(IdUsuario);
        }

        public void MostrarUsuario(int id)
        {


            if(id > 0)
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
                Usuarios usuario = repositorio.Buscar(id);

                Usuario_label.Text = usuario.Usuario.ToString();
                Permiso_label.Text = usuario.Permiso.ToString();
            }
            else
            {
                Usuario_label.Text = "Solo Usuarios";
                Permiso_label.Text = "Nuevo";
            }

        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Permiso_label.Text == "Almacen" || Permiso_label.Text == "Administrador")
            {
                rProductos p = new rProductos(IdUsuario);
                p.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario","No Hay Permiso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Permiso_label.Text == "Contador" || Permiso_label.Text == "Administrador")
            {
                rProveedores p = new rProveedores(IdUsuario);
                p.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void OrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Permiso_label.Text == "Contador" || Permiso_label.Text == "Administrador")
            {
                rCompras o = new rCompras(IdUsuario);
                o.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Permiso_label.Text == "Almacen"|| Permiso_label.Text == "Contador" || Permiso_label.Text == "Administrador")
            {
                cProductos p = new cProductos();
                p.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Permiso_label.Text == "Nuevo" || Permiso_label.Text == "Administrador")
            {
                rUsuarios u = new rUsuarios();
                u.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
  
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Permiso_label.Text == "Administrador" || Permiso_label.Text == "Contador")
            {
                cUsuarios  u = new cUsuarios();
                u.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(Permiso_label.Text == "Administrador" || Permiso_label.Text == "Contador")
            {
                cProveedores u = new cProveedores();
                u.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void PagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Permiso_label.Text == "Administrador" || Permiso_label.Text == "Contador")
            {
                rPagos p = new rPagos(IdUsuario);
                p.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Permiso_label.Text == "Administrador" || Permiso_label.Text == "Contador")
            {
                cCompras c = new cCompras();
                c.Show();
            }
            else
            {
                MessageBox.Show("No se puede acceder con este usuario", "No Hay Permiso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
