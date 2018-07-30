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
            Repositorio<Articulos> ArtRepositorio = new Repositorio<Articulos>(new Contexto());

            ClientecomboBox.DataSource = ArtRepositorio.GetList(c => true);
            ClientecomboBox.ValueMember = "ClienteId";
            ClientecomboBox.DisplayMember = "Nombres";
        }

        private DeudasClientes LlenaClase()
        {
            DeudasClientes entrada = new DeudasClientes();

            entrada.IdDeudas = Convert.ToInt32(UsuarioIDnumericUpDown.Value);
            entrada.ClienteID = ClientecomboBox.SelectedIndex - 1;
            entrada.Deuda = Convert.ToDecimal(DeudatextBox.Text);
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
            if (UsuarioIDnumericUpDown.Value == 0)
            {
                MYerrorProvider.SetError(UsuarioIDnumericUpDown, "Coloque un ID mayor a 0");
                Limpiar();
            }
            else
            {
                //MYerrorProvider.Clear();
                //int id = Convert.ToInt32(UsuarioIDnumericUpDown.Value);
                //Entidades.Clientes tipo;
                ////tipo = BLL.ClientesBLL.Buscar(p => p.IdDeudas == id);
                //if (tipo != null)
                //{

                //    ClientecomboBox.Text = tipo.ClienteId.ToString();
                //    DeudatextBox.Text = tipo.Credito.ToString();
                //    MessageBox.Show("Resultados de su busqueda");
                //}
                //else
                //{
                //    MessageBox.Show("No existe ninguna Deuda con ese Id.");
                //    Limpiar();
                //}

            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            DeudasClientes entrada;
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = (int)UsuarioIDnumericUpDown.Value;
            DeudasClientes EntradaAnterior = BLL.DeudasClientesBLL.Buscar(id);
            entrada = LlenaClase();


            if (UsuarioIDnumericUpDown.Value == 0)
            {
                Paso = BLL.DeudasClientesBLL.Guardar(entrada);

            }
            else
            {

                Paso = BLL.DeudasClientesBLL.Mofidicar(entrada, EntradaAnterior);

            }

            if (Paso)
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void ClientecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DeudatextBox.Text = db.clientes.Find(Convert.ToInt32(ClientecomboBox.SelectedValue)).Credito.ToString();
        }

        private void SaldarDeudas_Load(object sender, EventArgs e)
        {

        }
    }
}
