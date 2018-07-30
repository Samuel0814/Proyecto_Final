using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Entidades.Clientes;

namespace Warehouse_Pharmacy_System.UI.Registros
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
            SexocomboBox.Items.Add(Genero.Femenino);
            SexocomboBox.Items.Add(Genero.Masculino);
            
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {

        }

        private Clientes LlenaClase()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = Convert.ToInt32(ClienteIDnumericUpDown.Value);
            clientes.Nombres = NombretextBox.Text;
            clientes.Direccion = DirecciontextBox.Text;
            clientes.Email = EmailtextBox.Text;
            clientes.Sexo = (Genero)SexocomboBox.SelectedValue;
            clientes.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            clientes.Credito = 0;
            clientes.MaximoCredicto = Convert.ToDecimal(creditomaximotextBox.Text);
            clientes.Cedula = CedulamaskedTextBox.Text;
            clientes.Telefono = TelefonomaskedTextBox.Text;
            return clientes;
        }

        private void Limpiar()
        {
            ClienteIDnumericUpDown.Value = 0;
            NombretextBox.Clear();
            DirecciontextBox.Clear();
            EmailtextBox.Clear();
            SexocomboBox.SelectedValue = 0;
            CreditotextBox.Clear();
            FechaNacimientodateTimePicker.Value = DateTime.Now;
            creditomaximotextBox.Clear();
            CedulamaskedTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            MYerrorProvider.Clear();
        }

        private bool HayErrores()
        {

            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MYerrorProvider.SetError(NombretextBox,
                    "No Debes debes dejar el nombre del cliente vacio");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                MYerrorProvider.SetError(DirecciontextBox,
                    "No Debes debes dejar la direccion vacia");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MYerrorProvider.SetError(EmailtextBox,
                    "Debes Introducir un email");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(CedulamaskedTextBox.Text))
            {
                MYerrorProvider.SetError(CedulamaskedTextBox,
                    "Debe introducir una cedula");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
            {
                MYerrorProvider.SetError(TelefonomaskedTextBox,
                    "No debe dejar el telefono vacio");
                HayErrores = true;
            }
            return HayErrores;


        }
        

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
