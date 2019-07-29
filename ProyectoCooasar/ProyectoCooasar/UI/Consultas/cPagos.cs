using BLL;
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

namespace ProyectoCooasar.UI.Consultas
{
    public partial class cPagos : Form
    {
        private List<Pagos> listaPagos;
        public cPagos()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            Pagos c = new Pagos();

            if (Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0://Todo
                        listaPagos = PagosBLL.GetList(p => true);
                        break;

                    case 1://Id
                        int id = 0;
                        if (int.TryParse(Criterio_textBox.Text, out id))
                        {
                            id = Convert.ToInt32(Criterio_textBox.Text);
                            listaPagos = PagosBLL.GetList(p => p.PagoId == id);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;
                    case 2://Balance
                        decimal balance = 0;
                        if (decimal.TryParse(Criterio_textBox.Text, out balance))
                        {
                            balance = Convert.ToInt32(Criterio_textBox.Text);
                            listaPagos = PagosBLL.GetList(p => p.PagoTotal == balance);
                        }
                        else
                        {
                            MessageBox.Show("No Puedes Hacer Esto");
                        }
                        break;

                    case 3://UsuarioId
                        int usuarioId = 0;
                        if (int.TryParse(Criterio_textBox.Text, out usuarioId))
                        {
                            usuarioId = Convert.ToInt32(Criterio_textBox.Text);
                            listaPagos = PagosBLL.GetList(p => p.UsuarioId == usuarioId);
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
                listaPagos = PagosBLL.GetList(p => true);
            }

            if (FiltroFecha_checkBox.Checked == true)
            {
                listaPagos = listaPagos.Where(p => p.Fecha.Date >= Desde_dateTimePicker.Value.Date && p.Fecha.Date <= Hasta_dateTimePicker.Value.Date).ToList();
            }

            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = listaPagos;
        }
    }
}
