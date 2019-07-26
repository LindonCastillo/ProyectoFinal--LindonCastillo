using Entidades;
using ProyectoCooasar.BLL;
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
    public partial class cProveedores : Form
    {
        private List<Proveedores> listaProveedores;
        public cProveedores()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();

            if (Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0://Todo
                        listaProveedores = repositorio.GetList(p => true);
                        break;

                    case 1://Id
                        int id = 0;
                        if (int.TryParse(Criterio_textBox.Text, out id))
                        {
                            id = Convert.ToInt32(Criterio_textBox.Text);
                            listaProveedores = repositorio.GetList(p => p.ProveedorId == id);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 2://Nombre
                        listaProveedores = repositorio.GetList(p => p.Nombre.Contains(Criterio_textBox.Text));
                        break;

                    case 3://Tipo
                        listaProveedores = repositorio.GetList(p => p.Tipo.Contains(Criterio_textBox.Text));
                        break;

                    case 4://TipoMoneda
                        listaProveedores = repositorio.GetList(p => p.TipoMoneda.Contains(Criterio_textBox.Text));
                        break;

                    case 5://Telefono
                        listaProveedores = repositorio.GetList(p => p.Telefono.Contains(Criterio_textBox.Text));
                        break;

                    case 6://Direccion
                        listaProveedores = repositorio.GetList(p => p.Direccion.Contains(Criterio_textBox.Text));
                        break;

                    case 7://RNC
                        listaProveedores = repositorio.GetList(p => p.RNC.Contains(Criterio_textBox.Text));
                        break;
                }

            }
            else
            {
                listaProveedores = repositorio.GetList(p => true);
            }

            if (FiltroFecha_checkBox.Checked == true)
            {
                listaProveedores = listaProveedores.Where(c => c.Fecha.Date >= Desde_dateTimePicker.Value.Date && c.Fecha.Date <= Hasta_dateTimePicker.Value.Date).ToList();
            }

            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = listaProveedores;
        }

        private void Imprimir_button_Click(object sender, EventArgs e)
        {

        }
    }
    
}
