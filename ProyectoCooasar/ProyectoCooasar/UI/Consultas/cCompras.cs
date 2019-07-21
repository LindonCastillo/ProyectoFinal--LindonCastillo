using BLL;
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

namespace ProyectoCooasar.UI.Consultas
{
    public partial class cCompras : Form
    {
        private List<Compras> listaCompras;
        public cCompras()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            Compras c= new Compras();

            if (Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0://Todo
                        listaCompras = ComprasBLL.GetList(p => true);
                        break;

                    case 1://Id
                        int id = 0;
                        if (int.TryParse(Criterio_textBox.Text, out id))
                        {
                            id = Convert.ToInt32(Criterio_textBox.Text);
                            listaCompras = ComprasBLL.GetList(p => p.CompraId == id);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 2://ProveedorId
                        int IdProveedor = 0;
                        if (int.TryParse(Criterio_textBox.Text, out IdProveedor))
                        {
                            IdProveedor = Convert.ToInt32(Criterio_textBox.Text);
                            listaCompras = ComprasBLL.GetList(p => p.ProveedorId == IdProveedor);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;
                    case 3://Balance
                        decimal balance = 0;
                        if (decimal.TryParse(Criterio_textBox.Text, out balance))
                        {
                            balance = Convert.ToInt32(Criterio_textBox.Text);
                            listaCompras = ComprasBLL.GetList(p => p.Balance == balance);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 4://Itbis
                        int Itbis = 0;
                        if (int.TryParse(Criterio_textBox.Text, out Itbis))
                        {
                            Itbis = Convert.ToInt32(Criterio_textBox.Text);
                            listaCompras = ComprasBLL.GetList(p => p.Itbis == Itbis);
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
                listaCompras = ComprasBLL.GetList(p => true);
            }

            if (FiltroFecha_checkBox.Checked == true)
            {
                listaCompras = listaCompras.Where(p => p.Fecha.Date >= Desde_dateTimePicker.Value.Date && p.Fecha.Date <= Hasta_dateTimePicker.Value.Date).ToList();
            }

            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = listaCompras;
        }
    }
    
}
