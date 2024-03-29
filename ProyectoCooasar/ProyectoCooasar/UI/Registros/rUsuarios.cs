﻿using ProyectoCooasar.BLL;
using ProyectoCooasar.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCooasar.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public int IdUsuario;
        public rUsuarios(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            UsuarioId_numericUpDown.Value = 0;
            Nombre_textBox.Text = string.Empty;
            Email_textBox.Text = string.Empty;
            Usuario_textBox.Text = string.Empty;
            Clave_textBox.Text = string.Empty;
            Administrador_radioButton.Checked = false;
            Contador_radioButton.Checked = false;
            Almacen_radioButton.Checked = false;
            FechaIngreso_dateTimePicker.Value = DateTime.Now;
        }

        private bool Validar()
        {
            ErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(Nombre_textBox.Text))
            {
                ErrorProvider.SetError(Nombre_textBox, "El campo Nombre no puede estar vacío");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Email_textBox.Text))
            {
                ErrorProvider.SetError(Email_textBox, "El campo Email no puede estar vacío");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Usuario_textBox.Text))
            {
                ErrorProvider.SetError(Usuario_textBox, "El campo Usuario no puede estar vacío");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Clave_textBox.Text))
            {
                ErrorProvider.SetError(Clave_textBox, "El campo Clave no puede estar vacío");
                paso = false;
            }

            decimal Prueba = 0;
            if (decimal.TryParse(Nombre_textBox.Text, out Prueba))
            {
                ErrorProvider.SetError(Nombre_textBox, "El campo Nombre no pueden ser números");
                paso = false;
            }

            if (Administrador_radioButton.Checked == false && Contador_radioButton.Checked == false && Almacen_radioButton.Checked == false)
            {
                ErrorProvider.SetError(Niveles_panel, "Se debe seleccionar un ragon");
                paso = false;
            }

            if (UsuarioId_numericUpDown.Value == 0)
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
                var listado = new List<Usuarios>();
                listado = repositorio.GetList(p => true);
                string descripcion = Nombre_textBox.Text;
                foreach (var i in listado)
                {
                    if (descripcion == i.Nombre)
                    {
                        MessageBox.Show("Este Usuario ya está registrado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        paso = false;
                    }
                }
            }

            return paso;
        }

        private string ElegirNivel()
        {
            string nivel = string.Empty;
            if (Administrador_radioButton.Checked)
                nivel = "Administrador";

            if (Contador_radioButton.Checked)
                nivel = "Contador";

            if (Almacen_radioButton.Checked)
                nivel = "Almacen";

            return nivel;
        }

        public string Encriptar(string cadenaEncriptada)
        {
            string resultado = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaEncriptada);
            resultado = Convert.ToBase64String(encryted);

            return resultado;
        }

        public string DesEncriptar(string cadenaDesencriptada)
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaDesencriptada);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);

            return resultado;
        }
        private Usuarios LlenarClase()
        {
            Usuarios Usuario = new Usuarios();
            Usuario.UsuarioId = Convert.ToInt32(UsuarioId_numericUpDown.Value);
            Usuario.Nombre = Convert.ToString(Nombre_textBox.Text.Trim());
            Usuario.Email = Convert.ToString(Email_textBox.Text.Trim());
            Usuario.Usuario = Convert.ToString(Usuario_textBox.Text.Trim());
            Usuario.Clave = Encriptar(Clave_textBox.Text.Trim());
            Usuario.Permiso = ElegirNivel();
            Usuario.FechaIngreso = FechaIngreso_dateTimePicker.Value;

            return Usuario;
        }

        private void LlenarRadioButton(Usuarios usuario)
        {
            if (usuario.Permiso == "Administrador")
                Administrador_radioButton.Checked = true;

            if (usuario.Permiso == "Contador")
                Contador_radioButton.Checked = true;

            if (usuario.Permiso == "Almacen")
                Almacen_radioButton.Checked = true;
        }

        private void LlenarCampos(Usuarios usuarios)
        {
            UsuarioId_numericUpDown.Value = usuarios.UsuarioId;
            Nombre_textBox.Text = usuarios.Nombre;
            Email_textBox.Text = usuarios.Email;
            Usuario_textBox.Text = usuarios.Usuario;
            Clave_textBox.Text = DesEncriptar(usuarios.Clave);
            FechaIngreso_dateTimePicker.Value = usuarios.FechaIngreso;
            LlenarRadioButton(usuarios);
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios Usuario = repositorio.Buscar((int)UsuarioId_numericUpDown.Value);
            return (Usuario != null);
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios Usuario;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            Usuario = LlenarClase();

            if (UsuarioId_numericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(Usuario);

                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible guardar!!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un usuario que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(Usuario);
                Limpiar();
                MessageBox.Show("Se modifico con Exito!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            int id = Convert.ToInt32(UsuarioId_numericUpDown.Value);
            ErrorProvider.Clear();

            if (UsuarioId_numericUpDown.Value == IdUsuario)
            {
                MessageBox.Show("No se puede eliminar este usuario", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            Limpiar();
            try
            {
                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar este usuario", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar!");
            }
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios Usuario;
            int id = Convert.ToInt32(UsuarioId_numericUpDown.Value);


            Limpiar();
            try
            {
                Usuario = repositorio.Buscar(id);

                if (Usuario != null)
                {
                    LlenarCampos(Usuario);
                    MessageBox.Show("Usuario Encontrado!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario No Encontrado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar!");
            }
        }
    }
}
