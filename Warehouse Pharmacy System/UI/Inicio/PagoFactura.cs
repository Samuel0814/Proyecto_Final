using DAL;
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
    public partial class PagoFactura : Form
    {
        decimal SumTotal;
        public PagoFactura()
        {
            SumTotal = 0;
            InitializeComponent();
            llenarClienteBox();
        }

        private void llenarClienteBox()
        {
            Contexto db = new Contexto();
            var cliente = db.clientes.ToList();
            ClientecomboBox.DataSource = cliente;
            ClientecomboBox.ValueMember ="ClienteId";
            ClientecomboBox.DisplayMember = "Nombres";
        }

        private void ClientecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Contexto db = new Contexto();
           
            try
            {
                int idCliente = Convert.ToInt32(ClientecomboBox.SelectedValue);
                //select * from Facturas where EstaSaldada='false' and IdCliente=1
                var Factura = db.Facturas.Where(f => f.IdCliente == idCliente && f.EstaSaldada==false);
                FacturasdataGridView.DataSource = Factura.ToList();
                FacturasdataGridView.Columns[2].Visible = false;
                FacturasdataGridView.Columns[7].Visible = false;
                FacturasdataGridView.Columns[9].Visible = false;

            }
            catch 
            {

              
            }
        }

        private void FacturasdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(FacturasdataGridView.DataSource!=null)
                {
                    Pagarbutton.Enabled = true;
                    checkBox1.Enabled = true;
                }
                else
                {
                    Pagarbutton.Enabled = false;
                    checkBox1.Enabled   = false;
                }
            }
            catch 
            {

             
            }
        }

        private void CalcularTotal(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SumTotal = 0;
                /*
                 foreach (DataGridViewRow row in datagridviews.Rows)
                    {
                       currQty += row.Cells["qty"].Value;
                       //More code here
                    }*/
                foreach (DataGridViewRow item in FacturasdataGridView.Rows)
                {
                    if((bool)item.Cells[0].Value)
                    {
                        SumTotal += Convert.ToDecimal(item.Cells["Total"].Value);
                        

                    }
                }
                TotaltextBox.Text =  SumTotal.ToString();

            }
            catch
            {

                
            }
        }

        private void Pagarbutton_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();
            double efectivo = Convert.ToDouble(EfectivotextBox.Value);
            double total = double.Parse(TotaltextBox.Text);
           
            if (efectivo >= total)
            {
                try
                {
                    foreach (DataGridViewRow item in FacturasdataGridView.Rows)
                    {
                        if ((bool)item.Cells[0].Value)
                        {
                            int id = Convert.ToInt32(item.Cells["IdFactura"].Value);
                            var fact = db.Facturas.Find(id);
                            fact.EstaSaldada = true;


                        }

                    }
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Su pago se ha realizado correctamente");
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad mayor o igual al monto a pagar");
            }
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    foreach (DataGridViewRow item in FacturasdataGridView.Rows)
                    {
                        item.Cells[0].Value = true;

                    }

                }
                catch 
                {

                    
                }
            }
            else
            {

                try
                {
                    foreach (DataGridViewRow item in FacturasdataGridView.Rows)
                    {
                        item.Cells[0].Value = false;

                    }

                }
                catch
                {


                }
            }      
        }

        private void FacturasdataGridView_Click(object sender, EventArgs e)
        {
            CalcularTotal(null, null);
        }

        private void EfectivotextBox_ValueChanged(object sender, EventArgs e)
        {
            double devuelta;
            try
            {
                if (string.IsNullOrEmpty(TotaltextBox.Text))
                {

                }else
                {
                    devuelta =double.Parse(EfectivotextBox.Value.ToString())-double.Parse(TotaltextBox.Text) ;
                    DevueltatextBox.Text = devuelta.ToString();
                }
            }
            catch 
            {

                throw;
            }
        }

        private void TotaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PagoFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
