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
    public partial class RegistroCategorias : Form
    {
        public RegistroCategorias()
        {
            InitializeComponent();
        }

        private Categorias LlenaClase()
        {
            Categorias categorias = new Categorias();

            categorias.CategoriaId = Convert.ToInt32(CategoriaIDnumericUpDown.Value);
            categorias.NombreCategoria = DescripciontextBox.Text;
            return categorias;
        }

        private bool HayErrores()
        {

            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MYerrorProvider.SetError(DescripciontextBox,
                    "Debes debes dejar la descripcion vacia");
                HayErrores = true;
            }
            return HayErrores;

        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
