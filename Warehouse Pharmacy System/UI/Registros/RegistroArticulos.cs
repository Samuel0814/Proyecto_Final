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
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent();
            LlenaComboBox();
        }

        private void LlenaComboBox()
        {
            Repositorio<Categorias> ArtRepositorio = new Repositorio<Categorias>(new Contexto());

            CategoriacomboBox.DataSource = ArtRepositorio.GetList(c => true);
            CategoriacomboBox.ValueMember = "CategoriaId";
            CategoriacomboBox.DisplayMember = "NombreCategoria";

        }

        private Articulos LlenaClase()
        {
            Articulos articulos = new Articulos();

            articulos.IdArticulo = Convert.ToInt32(ArticuloIdnumericUpDown.Value);
            articulos.NombreArticulo = NombreArticulotextBox.Text;
            articulos.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
            articulos.PrecioVenta = Convert.ToDecimal(PrecioVentatextBox.Text);
            articulos.PrecioCompra = Convert.ToDecimal(PrecioCompratextBox.Text);
            articulos.FechaIngreso = FechaIngresodateTimePicker.Value;
            articulos.CategoriaId = Convert.ToInt32(CategoriacomboBox.SelectedValue);
            articulos.ITBIS = Convert.ToDecimal(ITBIStextBox.Text);
            return articulos;
        }

        private void Limpiar()
        {
            ArticuloIdnumericUpDown.Value = 0;
            NombreArticulotextBox.Clear();
            ExistenciatextBox.Clear();
            PrecioVentatextBox.Clear();
            PrecioCompratextBox.Clear();
            FechaIngresodateTimePicker.Value = DateTime.Now;
            CategoriacomboBox.SelectedValue = 0;
            ITBIStextBox.Clear();
            MYerrorProvider.Clear();
        }

        private bool HayErrores()
        {

            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(NombreArticulotextBox.Text))
            {
                MYerrorProvider.SetError(NombreArticulotextBox,
                    "No debes dejar el nombre del articulo vacio");
                HayErrores = true;
            }
      

            if (String.IsNullOrWhiteSpace(ExistenciatextBox.Text))
            {
                MYerrorProvider.SetError(ExistenciatextBox,
                    "No debes dejar la Existencia vacia");
                HayErrores = true;
            }
          

            if (String.IsNullOrWhiteSpace(PrecioVentatextBox.Text))
            {
                MYerrorProvider.SetError(PrecioVentatextBox,
                    "No debes dejar el precio de venta vacio");
                HayErrores = true;
            }
         

            if (String.IsNullOrWhiteSpace(PrecioCompratextBox.Text))
            {
                MYerrorProvider.SetError(PrecioCompratextBox,
                    "No debes dejar el precio de compra vacio");
                HayErrores = true;
            }
           

            if (String.IsNullOrWhiteSpace(ITBIStextBox.Text))
            {
                MYerrorProvider.SetError(ITBIStextBox,
                    "No debes dejar el ITBIS del articulo vacio");
                HayErrores = true;
            }

            return HayErrores;


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulos;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            articulos = LlenaClase();


            if (ArticuloIdnumericUpDown.Value == 0)
                Paso = BLL.ArticuloBLL.Guardar(articulos);
            else
                Paso = BLL.ArticuloBLL.Modificar(LlenaClase());



            if (Paso)
            {
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloIdnumericUpDown.Value);

            if (BLL.ArticuloBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloIdnumericUpDown.Value);
            Articulos articulos = BLL.ArticuloBLL.Buscar(id);

            if (articulos != null)
            {
                NombreArticulotextBox.Text = articulos.NombreArticulo;
                ExistenciatextBox.Text = articulos.Existencia.ToString();
                PrecioVentatextBox.Text = articulos.PrecioVenta.ToString();
                PrecioCompratextBox.Text = articulos.PrecioCompra.ToString();
                FechaIngresodateTimePicker.Value = articulos.FechaIngreso;
                CategoriacomboBox.SelectedValue = Convert.ToInt32(articulos.CategoriaId);
                ITBIStextBox.Text = articulos.ITBIS.ToString();
            }
        }

        private void RegistroArticulos_Load(object sender, EventArgs e)
        {

        }

        private void CategoriacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
