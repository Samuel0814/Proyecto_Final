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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {

            }
        }

        private bool ValidarCampos()
        {
            if(NombreArticulotextBox.Text.Trim().Length<1)
            {

                NombreArticulotextBox.Focus();
                return false;
            }
            if(ContraseñatextBox.Text.Trim().Length<1)
            {
                ContraseñatextBox.Focus();
                return false;
            }
            if(ConfirmarContraseñatextBox.Text.Trim().Length<1)
            {
                ConfirmarContraseñatextBox.Focus();
                return false;

            }
            if()

            return true;
        }
    }
}
