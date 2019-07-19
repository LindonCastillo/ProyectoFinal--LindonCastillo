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
    public partial class cProductos : Form
    {
        private List<Productos> listaProductos;
        public cProductos()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            if (Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0://Todo
                        listaProductos = repositorio.GetList(p => true);
                        break;

                    case 1://Id
                        int id = 0;
                        if (int.TryParse(Criterio_textBox.Text, out id))
                        {
                            id = Convert.ToInt32(Criterio_textBox.Text);
                            listaProductos = repositorio.GetList(p => p.ProductoId == id);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 2://Nombre
                        listaProductos = repositorio.GetList(p => p.Nombre.Contains(Criterio_textBox.Text));
                        break;

                    case 3://Cantidad
                        int cantidad = 0;
                        if (int.TryParse(Criterio_textBox.Text, out cantidad))
                        {
                            cantidad = Convert.ToInt32(Criterio_textBox.Text);
                            listaProductos = repositorio.GetList(p => p.Cantidad == cantidad);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 4://PrecioCompra
                        decimal Precio = 0;
                        if (decimal.TryParse(Criterio_textBox.Text, out Precio))
                        {
                            Precio = Convert.ToDecimal(Criterio_textBox.Text);
                            listaProductos = repositorio.GetList(p => p.PrecioCompra == Precio);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 5://PrecioVenta
                        decimal Precio2 = 0;
                        if (decimal.TryParse(Criterio_textBox.Text, out Precio2))
                        {
                            Precio2 = Convert.ToDecimal(Criterio_textBox.Text);
                            listaProductos = repositorio.GetList(p => p.PrecioVenta == Precio2);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 6://Itbis
                        int itbis = 0;
                        if (int.TryParse(Criterio_textBox.Text, out itbis))
                        {
                            itbis = Convert.ToInt32(Criterio_textBox.Text);
                            listaProductos = repositorio.GetList(p => p.ITBIS == itbis);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;
                }

            }
            else
            {
                listaProductos = repositorio.GetList(p => true);
            }

            if (FiltroFecha_checkBox.Checked == true)
            {
                listaProductos = listaProductos.Where(c => c.Fecha.Date >= Desde_dateTimePicker.Value.Date && c.Fecha.Date <= Hasta_dateTimePicker.Value.Date).ToList();
            }

            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = listaProductos;
        }
    }
    
}
