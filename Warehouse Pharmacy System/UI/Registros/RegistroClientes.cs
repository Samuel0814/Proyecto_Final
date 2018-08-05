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
            clientes.Sexo = (Genero)SexocomboBox.SelectedIndex;
            clientes.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            
            clientes.MaximoCredicto =(creditomaximotextBox.Text==string.Empty)?0:decimal.Parse(creditomaximotextBox.Text);
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

            string ced = CedulamaskedTextBox.Text.Replace('-', ' ').Trim();
            if (CedulamaskedTextBox.Text.Replace('-',' ').Trim().Length<11)
            {
                MYerrorProvider.SetError(CedulamaskedTextBox,
                    "Debe introducir una cedula");
                MessageBox.Show("la longitud de la cedula es igual a "+ced.Length);
                HayErrores = true;
            }

            string tel = TelefonomaskedTextBox.Text.Replace('-', ' ').Trim();
            if (TelefonomaskedTextBox.Text.Replace('-',' ').Trim().Trim().Length<12)
            {
                MYerrorProvider.SetError(TelefonomaskedTextBox,
                    "No debe dejar el telefono vacio");
                HayErrores = true;
            }
            
            return HayErrores;


        }
        

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var clientes = BLL.ClientesBLL.Buscar(Convert.ToInt32(ClienteIDnumericUpDown.Value));
            Contexto db = new Contexto();
           
            if (clientes != null)
            {
                NombretextBox.Text = clientes.Nombres;
                DirecciontextBox.Text = clientes.Direccion;
                EmailtextBox.Text = clientes.Email;

                SexocomboBox.SelectedIndex = Convert.ToInt32(clientes.Sexo);
                
                FechaNacimientodateTimePicker.Value = clientes.FechaNacimiento;
               

                creditomaximotextBox.Text = clientes.MaximoCredicto.ToString();
                CedulamaskedTextBox.Text = clientes.Cedula;
                TelefonomaskedTextBox.Text = clientes.Telefono;

            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes clientes;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clientes = LlenaClase();


            if (ClienteIDnumericUpDown.Value == 0)
                Paso = BLL.ClientesBLL.Guardar(clientes);
            else
                Paso = BLL.ClientesBLL.Modificar(LlenaClase());


            if (Paso)
            {
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClienteIDnumericUpDown.Value);

            if (BLL.ClientesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SexocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void creditomaximotextBox_TextChanged(object sender, EventArgs e)
        {
            if(!IsNumber(creditomaximotextBox.Text))
            {
                creditomaximotextBox.Clear();
            }
        }

        private bool IsNumber(string text)
        {
            try
            {
                decimal.Parse(text);

            }
            catch 
            {

                return false;
            }
            return true;
        }

        private void CedulamaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
