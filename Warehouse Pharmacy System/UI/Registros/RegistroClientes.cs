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
            clientes.Direccion = Direccion.Text;
            clientes.Email = Direccion.Text;
            clientes.Sexo = (Genero)SexocomboBox.SelectedValue;
            clientes.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            clientes.Credito = 0;
            //clientes.CategoriaId = Convert.ToInt32(CategoriacomboBox.SelectedValue);
            //clientes.ITBIS = Convert.ToDecimal(ITBIStextBox.Text);
            return clientes;
        }

        private void Limpiar()
        {
            //ArticuloIdnumericUpDown.Value = 0;
            //NombreArticulotextBox.Clear();
            //ExistenciatextBox.Clear();
            //PrecioVentatextBox.Clear();
            //PrecioCompratextBox.Clear();
            //CodigoArticulotextBox.Clear();
            //FechaIngresodateTimePicker.Value = DateTime.Now;
            //CategoriacomboBox.SelectedValue = 0;
            //ITBIStextBox.Clear();
            MYerrorProvider.Clear();
        }

    /*    private bool HayErrores()
        {

            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(NombreArticulotextBox.Text))
            {
                MYerrorProvider.SetError(NombreArticulotextBox,
                    "Debes debes dejar el nombre del articulo vacio");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(ExistenciatextBox.Text))
            {
                MYerrorProvider.SetError(ExistenciatextBox,
                    "Debes debes dejar la Existencia vacia");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(PrecioVentatextBox.Text))
            {
                MYerrorProvider.SetError(PrecioVentatextBox,
                    "Debes debes dejar el precio de venta vacio");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(PrecioCompratextBox.Text))
            {
                MYerrorProvider.SetError(PrecioCompratextBox,
                    "Debes debes dejar el precio de compra vacio");
                HayErrores = true;
            }


            if (String.IsNullOrWhiteSpace(CodigoArticulotextBox.Text))
            {
                MYerrorProvider.SetError(CodigoArticulotextBox,
                    "Debes debes dejar el codigo del articulo vacio");
                HayErrores = true;
            }
            return HayErrores;


        }
        */

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
