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
    public partial class RegistroVenta : Form
    {
        public RegistroVenta()
        {
            InitializeComponent();
            BuscarArticulos();
            ClientecomboBox.DataSource = new Contexto().clientes.ToList();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BuscarArticulos();
               
                
                
                
       }
        public void BuscarArticulos()
        {
            List<Articulos> ArticulosList = new Contexto().articulos.ToList();

            if(!string.IsNullOrWhiteSpace(CodigoArticulotextbox.Text))
            {
                int id;
                try
                {
                    id = int.Parse(CodigoArticulotextbox.Text);
                    ArticulodataGridView.DataSource =(from articulo in ArticulosList
                                                     where articulo.IdArticulo==id
                                                     select articulo).ToList();

                }
                catch 
                {

                    
                }
              
            }else
            {
                if(!string.IsNullOrWhiteSpace(NombreArticulotextBox.Text))
                {
                    ArticulodataGridView.DataSource = (from articulo in ArticulosList
                                                       where articulo.NombreArticulo.Contains(NombreArticulotextBox.Text)
                                                       select articulo).ToList();
                }
                else
                {
                    ArticulodataGridView.DataSource = ArticulosList;
                                                 
                }
            }
            
            
           
            
            


        }

        private void ArticulodataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            if (ArticulodataGridView.DataSource!=null)
            {
                Agregarbutton.Enabled = true;
            }
            else
            {
                Agregarbutton.Enabled = false;
            }
        }

        private void Nombre(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                DevueltatextBox.Enabled = false;
                EfectivotextBox.Enabled = false;
            }
            else
            {
                DevueltatextBox.Enabled = true;
                EfectivotextBox.Enabled =true;

            }
        }
    }
}
