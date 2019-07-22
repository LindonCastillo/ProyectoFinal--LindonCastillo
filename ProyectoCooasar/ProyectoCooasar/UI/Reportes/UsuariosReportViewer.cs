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
    public partial class UsuariosReportViewer : Form
    {
        private List<Usuarios> listaUsuarios;
        public UsuariosReportViewer(List<Usuarios> usuarios)
        {
            InitializeComponent();
            this.listaUsuarios = usuarios;
            ReportUsuarios listadoUsuario = new ReportUsuarios();
            listadoUsuario.SetDataSource(listaUsuarios);

            Usuarios_crystalReportViewer.ReportSource = listadoUsuario;
            Usuarios_crystalReportViewer.Refresh();
        }
    }
}
