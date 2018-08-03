using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;
using Warehouse_Pharmacy_System.UI.Registros;

namespace Warehouse_Pharmacy_System.UI.Inicio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {

                if (UsuariosBLL.InicialSeccion(UsuariotextBox.Text,PasswordtextBox.Text))
                {


                    Visible = false;
                    Home frm = new Home();
                    frm.Show();
                    
                }
            }
        }

        public bool ValidarCampos()
        {
            if(UsuariotextBox.Text.Trim().Length<1)
            {
                MessageBox.Show("Favor llenar los campos vacio.");
                UsuariotextBox.Focus();
                return false;
            }
            if(PasswordtextBox.Text.Trim().Length<1)
            {
                MessageBox.Show("Favor llenar los campos vacios.");
                PasswordtextBox.Focus();
                return false;
            }



            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RegistroUsuarios().Show();
           
        }
    }
}
