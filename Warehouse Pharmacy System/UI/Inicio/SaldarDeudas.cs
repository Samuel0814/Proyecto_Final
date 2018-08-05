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

namespace Warehouse_Pharmacy_System.UI.Inicio
{
    public partial class SaldarDeudas : Form
    {
        Contexto db = new Contexto();
        public SaldarDeudas()
        {
            InitializeComponent();
            //ClientecomboBox.DataSource = db.clientes.ToList();
            //ClientecomboBox.DisplayMember = "Nombres";
            //ClientecomboBox.ValueMember = "ClienteId";
            LlenaComboBox();
        }

        private void LlenaComboBox()
        {
            

            ClientecomboBox.DataSource = new Contexto().clientes.ToList();
            ClientecomboBox.ValueMember = "ClienteId";
            ClientecomboBox.DisplayMember = "Nombres";
        }

        private DeudasClientes LlenaClase()
        {
            DeudasClientes entrada = new DeudasClientes();

            entrada.IdDeudas = Convert.ToInt32(UsuarioIDnumericUpDown.Value);
            entrada.ClienteID = ClientecomboBox.SelectedIndex + 1;
           // entrada.Deuda = Convert.ToDecimal(DeudatextBox.Text);
            return entrada;
        }

        public static int TOINT(string nombre)
        {
            //int numero;
            //int.TryParse(nombre, out numero);
            //return numero;
           return int.Parse(nombre);
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(ClientecomboBox.Text))
            {
                MYerrorProvider.SetError(ClientecomboBox, "CAMPO VACIO");

                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(DeudatextBox.Text))
            {
                MYerrorProvider.SetError(DeudatextBox, "CAMPO VACIO");

                retorno = false;
            }
            return retorno;
        }

        private void Limpiar()
        {
            DeudatextBox.Clear();
            UsuarioIDnumericUpDown.Value = 0;
            EfectivotextBox.Clear();
            DevueltatextBox.Clear();

        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIDnumericUpDown.Value);

            if (BLL.DeudasClientesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClientecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var client = (Clientes)ClientecomboBox.SelectedItem;
                var deuda = new Contexto().deudas.Where(x => x.ClienteID == client.ClienteId).First();
                DeudatextBox.Text = deuda.DeudaTotal().ToString();
            }
            catch
            {

            }
           
           



        }

        private void SaldarDeudas_Load(object sender, EventArgs e)
        {

        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
