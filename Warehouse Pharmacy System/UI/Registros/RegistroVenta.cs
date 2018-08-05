using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse_Pharmacy_System.UI.Registros
{
    public partial class RegistroVenta : Form
    {
        public Facturas Facturas { get; set; }
        public RegistroVenta()
        {
            InitializeComponent();
            LlenarComboBox();
            Facturas = new Facturas();
        }

        private void LlenarCampos(Facturas facturas)
        {
            FacturaIDnumericUpDown.Value = facturas.IdFactura;
            FechadateTimePicker.Value = facturas.FechaVenta;
            SubTotalnumericUpDown.Value = Convert.ToInt32(facturas.SubTotal);
            ItbisnumericUpDown.Value = Convert.ToInt32(facturas.Itbis);
            TotalnumericUpDown.Value = Convert.ToInt32(facturas.Total);


            DetalledataGridView.DataSource = facturas.Detalle.ToList();
            int c = 0;
            foreach (var item in DetalledataGridView.Columns)
            {
                c++;

            }
            for (int i = 0; i < c; i++)
            {
                if (i > 8)
                {
                    DetalledataGridView.Columns[i].Visible = false;
                }
            }



        }

        private int ToInt(object valor)
        {
            int retorno = 0;

            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }



        private Facturas LlenaClase()
        {


            Facturas.IdFactura = Convert.ToInt32(FacturaIDnumericUpDown.Value);
            Facturas.FechaVenta = FechadateTimePicker.Value;
            Facturas.Total = Convert.ToSingle(TotalnumericUpDown.Value);
            Facturas.SubTotal = Convert.ToSingle(SubTotalnumericUpDown.Value);
            Facturas.Itbis = Convert.ToSingle(ItbisnumericUpDown.Value);
            Facturas.IdCliente = Convert.ToInt32(ClientecomboBox.SelectedValue);
            Facturas.ACredito = CreditocheckBox.Checked;
            Facturas.FechaExpiracion = DateTime.Now.AddDays(30);

            return Facturas;
        }

        private void LlenarComboBox()
        {
            Repositorio<Articulos> ArticuloRepositorio = new Repositorio<Articulos>(new Contexto());
            Repositorio<Clientes> Clienterepositorio = new Repositorio<Clientes>(new Contexto());

            ArticulocomboBox.DataSource = ArticuloRepositorio.GetList(c => true);
            ArticulocomboBox.ValueMember = "IdArticulo";
            ArticulocomboBox.DisplayMember = "NombreArticulo";

            ClientecomboBox.DataSource = Clienterepositorio.GetList(c => true);
            ClientecomboBox.ValueMember = "ClienteId";
            ClientecomboBox.DisplayMember = "Nombres";

        }

        private void MostrarPrecio()
        {
            List<Articulos> lArticulos = BLL.ArticuloBLL.GetList(c => c.NombreArticulo == ArticulocomboBox.Text);
            foreach (var item in lArticulos)
            {
                PrecionumericUpDown.Text = item.PrecioVenta.ToString();
               
            }
        }

        private void Total()
        {
            List<FacturasDetalles> detalle = (List<FacturasDetalles>)DetalledataGridView.DataSource;

            float Total = 0;

            decimal IteB;

            IteB = 0.18M;

            foreach (var item in detalle)
            {
                Total += item.Importe;
            }
            TotalnumericUpDown.Text = Total.ToString();

            ItbisnumericUpDown.Value = TotalnumericUpDown.Value * IteB;

            SubTotalnumericUpDown.Value = TotalnumericUpDown.Value - ItbisnumericUpDown.Value;


        }

        private void RestandoTotal()
        {

            float Total = 0;
            decimal IteB;

            IteB = 0.18M;


            foreach (var item in Facturas.Detalle)
            {
                Total -= item.Importe;
            }

            Total *= (-1);

            TotalnumericUpDown.Text = Total.ToString();

            ItbisnumericUpDown.Value = TotalnumericUpDown.Value * IteB;

            SubTotalnumericUpDown.Value = TotalnumericUpDown.Value - ItbisnumericUpDown.Value;




        }

        private bool HayErrores1()
        {
            bool HayErrores = false;

            if (string.IsNullOrEmpty(ClientecomboBox.Text))
            {
                MYerrorProvider.SetError(ClientecomboBox,
                    "Debes Tener registrado al menos un cliente registrado");
                HayErrores = true;
            }

            if (string.IsNullOrEmpty(ArticulocomboBox.Text))
            {
                MYerrorProvider.SetError(ArticulocomboBox,
                    "Debes Tener registrado al menos un articulo registrado");
                HayErrores = true;
            }


            if (CantidadnumericUpDown.Value == 0)
            {
                MYerrorProvider.SetError(CantidadnumericUpDown,
                    "Digite una cantidad");
                HayErrores = true;
            }

            return HayErrores;
        }


        private bool HayErrores()
        {
            bool HayErrores = false;

            if (DetalledataGridView.RowCount == 0)
            {
                MYerrorProvider.SetError(DetalledataGridView,
                    "Es obligatorio seleccionar los articulos ");
                HayErrores = true;
            }

            if (string.IsNullOrEmpty(ClientecomboBox.Text))
            {
                MYerrorProvider.SetError(ClientecomboBox,
                    "Debes Tener registrado al menos un cliente registrado");
                HayErrores = true;
            }


            if (string.IsNullOrEmpty(ArticulocomboBox.Text))
            {
                MYerrorProvider.SetError(ArticulocomboBox,
                    "Debes Tener registrado al menos un articulo registrado");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(FacturaIDnumericUpDown.Value);
            Facturas = BLL.FacturaBLL.Buscar(id);

            if (Facturas != null)
            {
                LlenarCampos(Facturas);
            }
            else
                MessageBox.Show("No encontrado!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (HayErrores1())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                FacturasDetalles detalle = new FacturasDetalles();

                detalle.IdFactura = (int)FacturaIDnumericUpDown.Value;
                detalle.IdArticulo = (int)ArticulocomboBox.SelectedValue;
                detalle.IdCliente = (int)ClientecomboBox.SelectedValue;
                detalle.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
                detalle.Precio = (float)Convert.ToInt32(PrecionumericUpDown.Text);
                detalle.Importe = (float)Convert.ToInt32(ImportenumericUpDown.Text);
                    
                AgregarDetalle(
                    detalle
                   );


                DetalledataGridView.DataSource = null;


                DetalledataGridView.DataSource = Facturas.Detalle;

                DetalledataGridView.Columns["ID"].Visible = false;
                DetalledataGridView.Columns["IdFactura"].Visible = false;

                Total();
            }
            CantidadnumericUpDown.Value = 0;
        }

        private void AgregarDetalle(FacturasDetalles facturasDetalles)
        {
            foreach (var item in Facturas.Detalle)
            {
                if (item.IdArticulo == facturasDetalles.IdArticulo)
                {
                    item.Cantidad += facturasDetalles.Cantidad;
                    item.Importe = item.Precio * item.Cantidad;
                    return;
                }

            }

            Facturas.Detalle.Add(facturasDetalles);


        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 )
            {

                List<FacturasDetalles> Detalle = (List<FacturasDetalles>)DetalledataGridView.DataSource;


                Facturas.Detalle.RemoveAt(Convert.ToInt32(DetalledataGridView.SelectedRows[0].Index));
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = Facturas.Detalle;

            }
        }

        private void Limpiar()
        {
            FacturaIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            ImportenumericUpDown.Value = 0; ;
            TotalnumericUpDown.Value = 0;
            DetalledataGridView.DataSource = null;
            SubTotalnumericUpDown.Value = 0;
            ItbisnumericUpDown.Value = 0;
            MYerrorProvider.Clear();
            Facturas.Detalle.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Facturas = LlenaClase();

            if (FacturaIDnumericUpDown.Value == 0)
            {
                Contexto db = new Contexto();
                Facturas = LlenaClase();
                Facturas.IdFactura = db.Facturas.ToList().Count + 1;

                Paso = BLL.FacturaBLL.Guardar(Facturas);

            }
            else
            {
                Facturas = LlenaClase();
                Paso = BLL.FacturaBLL.Modificar(Facturas);

            }

            if (Paso)
            {
                Nuevobutton.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(FacturaIDnumericUpDown.Value);


            if (BLL.FacturaBLL.Eliminar(id))
            {
       

                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ArticulocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarPrecio();
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Contexto db = new Contexto();
            var articulo = db.articulos.Find(ArticulocomboBox.SelectedValue);

            if (CantidadnumericUpDown.Value > decimal.Parse(articulo.Existencia.ToString()))
            {
                MessageBox.Show("la cantidad no debe exceder el inventario.");
                CantidadnumericUpDown.Value = 0;
            }
            else
            {
                MostrarPrecio();
                if (CantidadnumericUpDown.Value != 0)
                {
                    ImportenumericUpDown.Value = CantidadnumericUpDown.Value * PrecionumericUpDown.Value;
                }

            }
        }

        private void CreditocheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
