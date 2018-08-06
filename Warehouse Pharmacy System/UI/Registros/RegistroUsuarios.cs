using DAL;
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
                    limpiar();
                }
                else
                {
                    Contexto db = new Contexto();
                    if (db.usuario.Find(user.Id) != null)
                    {
                        BLL.UsuariosBLL.Modificar(user);
                        MessageBox.Show("El Usuario se ha Modificado con exito.");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No hay usuario registrado con el id:"+user.Id);
                    }
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
                MYerrorProvider.SetError(NombreArticulotextBox,
                    "No debes dejar este campo vacio");
                return false;
            }
            if(string.IsNullOrWhiteSpace(ContraseñatextBox.Text))
            {
                ContraseñatextBox.Focus();
                MYerrorProvider.SetError(ContraseñatextBox,
                     "No debes dejar este campo vacio");
                return false;
            }
            if(string.IsNullOrWhiteSpace(ConfirmarContraseñatextBox.Text))
            {
                ConfirmarContraseñatextBox.Focus();
                MYerrorProvider.SetError(ConfirmarContraseñatextBox,
                    "No debe dejar este campo vacio");
                return false;

            }
            if(!ContraseñatextBox.Text.Equals(ConfirmarContraseñatextBox.Text))
            {
                MYerrorProvider.SetError(ConfirmarContraseñatextBox,
                    "Las contraseñas no coinciden");
                //ContraseñatextBox.Clear();
                ConfirmarContraseñatextBox.Clear();
                return false;
            }
            

            return true;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
        
        
            Guardar_Modificar();
            
        
            
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
            if(UsuarioIDnumericUpDown.Value ==  0)
            {
                MessageBox.Show("Ingrese un ID mayor a 0");
            }
            else
            {
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
          
            
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIDnumericUpDown.Value);
            Usuarios usuarios = BLL.UsuariosBLL.Buscar(id);
            if(UsuarioIDnumericUpDown.Value == 0)
            {
                MessageBox.Show("Ingrese un ID mayor a o");
            }
            else
            {
                if (usuarios != null)
                {
                    NombreArticulotextBox.Text = usuarios.NombreUsuario;
                    TipocomboBox.SelectedItem = Convert.ToString(usuarios.Tipo);
                    ContraseñatextBox.Text = usuarios.PassUsuario;
                    ConfirmarContraseñatextBox.Text = usuarios.PassUsuario;
                }
                else
                {
                    MessageBox.Show("no se encuentran usuarios registrados en el ID seleccionado");
                }
            }
        }
    }
}
