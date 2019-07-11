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

namespace ProyectoCooasar.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var listado = new List<Usuarios>();
            if (Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = repositorio.GetList(p => true);
                        break;

                    case 1://Id
                        int id = 0;
                        if (int.TryParse(Criterio_textBox.Text, out id))
                        {
                            id = Convert.ToInt32(Criterio_textBox.Text);
                            listado = repositorio.GetList(p => p.UsuarioId == id);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 2://Nombre
                        listado = repositorio.GetList(p => p.Nombre.Contains(Criterio_textBox.Text));
                        break;

                    case 3://Usuario
                        listado = repositorio.GetList(p => p.Usuario.Contains(Criterio_textBox.Text));
                        break;
                }

                listado = listado.Where(c => c.FechaIngreso.Date >= Desde_dateTimePicker.Value.Date && c.FechaIngreso.Date <= Hasta_dateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = listado;
        }
    }
}
