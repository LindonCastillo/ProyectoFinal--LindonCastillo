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

namespace ProyectoCooasar.UI.Reportes
{
    public partial class ProveedoresReportViewer : Form
    {
        private List<Proveedores> listaProveedores;
        public ProveedoresReportViewer(List<Proveedores> proveedores)
        {
            InitializeComponent();
            this.listaProveedores = proveedores;
            ReportProveedores listadoProveedores = new ReportProveedores();
            listadoProveedores.SetDataSource(listaProveedores);

            Proveedores_ReportViewer.ReportSource = listadoProveedores;
            Proveedores_ReportViewer.Refresh();
        }
    }
}
