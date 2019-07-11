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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos p = new rProductos();
            p.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProveedores p = new rProveedores();
            p.Show();
        }

        private void OrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rOrdenCompra o = new rOrdenCompra();
            o.Show();
        }

        private void ProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cProductos p = new cProductos();
            p.Show();
        }
    }
}
