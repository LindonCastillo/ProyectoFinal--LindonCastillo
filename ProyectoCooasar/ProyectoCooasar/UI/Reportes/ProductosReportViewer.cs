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

namespace ProyectoCooasar.UI.Reportes
{
    public partial class ProductosReportViewer : Form
    {
        private List<Productos> listaProductos;
        public ProductosReportViewer(List<Productos> productos)
        {
            InitializeComponent();
            this.listaProductos = productos;
            ReportProductos listadoProductos = new ReportProductos();
            listadoProductos.SetDataSource(listaProductos);

            Producto_ReportViewer.ReportSource = listadoProductos;
            Producto_ReportViewer.Refresh();
        }


    }
}
