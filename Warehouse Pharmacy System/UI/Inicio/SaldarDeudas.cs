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
            ClientecomboBox.DataSource = db.clientes.ToList();
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";
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
            if (UsuarioIDnumericUpDown.Value == 0)
            {
                MYerrorProvider.SetError(UsuarioIDnumericUpDown, "Coloque un ID mayor a 0");
                Limpiar();
            }
            else
            {
                MYerrorProvider.Clear();
                int id = Convert.ToInt32(UsuarioIDnumericUpDown.Value);
                
             
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void ClientecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DeudatextBox.Text = db.clientes.Find(Convert.ToInt32(ClientecomboBox.SelectedValue)).Credito.ToString();
        }
    }
}
