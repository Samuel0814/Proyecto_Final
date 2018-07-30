using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse_Pharmacy_System.UI.Registros
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }


        private void Guardar_Modificar()
        {
            Usuarios user = llenarclase();
            if(ValidarCampos())
            {
                if(Convert.ToInt32(UsuarioIDnumericUpDown.Value)==0)
                {
                    BLL.UsuariosBLL.Guardar(user);
                    MessageBox.Show("El Usuario se ha Guardado con exito.");
                }
                else
                {
                    BLL.UsuariosBLL.Modificar(user);
                    MessageBox.Show("El Usuario se ha Modificado con exito.");
                }

            }
        }

        private Usuarios llenarclase()
        {
            return new Usuarios(Convert.ToInt32(UsuarioIDnumericUpDown.Value), NombreArticulotextBox.Text, ContraseñatextBox.Text, TipocomboBox.Text);
        }

        private bool ValidarCampos()
        {
            if(string.IsNullOrWhiteSpace(NombreArticulotextBox.Text))
            {
                NombreArticulotextBox.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(ContraseñatextBox.Text))
            {
                ContraseñatextBox.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(ConfirmarContraseñatextBox.Text))
            {
                ConfirmarContraseñatextBox.Focus();
                return false;

            }
            if(!ContraseñatextBox.Text.Equals(ConfirmarContraseñatextBox.Text))
            {
                ContraseñatextBox.Clear();
                ConfirmarContraseñatextBox.Clear();
                return false;
            }
            

            return true;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Guardar_Modificar();
            limpiar();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            NombreArticulotextBox.Clear();
            UsuarioIDnumericUpDown.Value = 0;
            TipocomboBox.SelectedIndex = 0;
            ContraseñatextBox.Clear();
            ConfirmarContraseñatextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIDnumericUpDown.Value);

          
            if (BLL.UsuariosBLL.Eliminar(id))
            {

                MessageBox.Show("El Usuario se ha Eliminado  con exito.");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar El usuario.");
            }
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIDnumericUpDown.Value);
            Usuarios usuarios = BLL.UsuariosBLL.Buscar(id);

            if (usuarios != null)
            {
                NombreArticulotextBox.Text = usuarios.NombreUsuario;
                //TipocomboBox.SelectedIndex = usuarios.Tipo;
                ContraseñatextBox.Text = usuarios.PassUsuario;
                ConfirmarContraseñatextBox.Text = usuarios.PassUsuario;
            }
        }
    }
}
