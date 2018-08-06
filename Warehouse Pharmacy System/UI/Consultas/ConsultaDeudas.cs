using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Warehouse_Pharmacy_System.UI.Inicio;
using Warehouse_Pharmacy_System.UI.Reportes;

namespace Warehouse_Pharmacy_System.UI.Consultas
{
    public partial class ConsultaDeudas : Form
    {
        //private List<SaldarDeudas> saldarDeudas;
        public ConsultaDeudas()
        {
            InitializeComponent();
        }

        private void Llenar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Clientes");
            FiltrocomboBox.Items.Insert(2, "Todo");
        }

        private void ConsultaDeudas_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            //if (saldarDeudas.Count == 0)
            //{
            //    MessageBox.Show("Reporte esta vacio");
            //    return;
            //}
            //DeudasViewer clienteViewer = new DeudasViewer(saldarDeudas);
            //clienteViewer.Show();
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 2)
            {
                CriteriotextBox.Visible = false;
                Criteriolabel.Visible = false;
            }
            else
            {
                CriteriotextBox.Visible = true;
                Criteriolabel.Visible = true;
            }
        }

        private void Buscatbutton_Click_1(object sender, EventArgs e)
        {
            Expression<Func<DeudasClientes, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.IdDeudas == id;
                    break;
                case 1:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.IdFactura == id;
                    break;

                case 2: //filtrando todos
                    //Expression<Func<DeudasClientes, bool>> filtro2 = a => true;
                    Contexto db = new Contexto();
                    var Consulta = from f in db.Facturas
                                   join d in db.deudas on f.IdFactura equals d.IdFactura
                                   join c in db.clientes on f.IdCliente equals c.ClienteId
                                   where f.EstaSaldada == false
                                   select new { Cliente = c.Nombres, f.FechaVenta, f.FechaExpiracion, f.Total };
                    ConsultadataGridView.DataSource= Consulta.ToList();
                    break;
            }




            //saldarDeudas = BLL.DeudasClientesBLL.GetList(filtro);
            //ConsultadataGridView.DataSource = saldarDeudas;
            ConsultadataGridView.DataSource = BLL.DeudasClientesBLL.GetList(filtro);
        }

        private void ClientecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Contexto db = new Contexto();

            try
            {
                int idCliente = Convert.ToInt32(FiltrocomboBox.SelectedValue);
                //select * from Facturas where EstaSaldada='false' and IdCliente=1
                var Factura = db.Facturas.Where(f => f.IdCliente == idCliente && f.EstaSaldada == false);
                ConsultadataGridView.DataSource = Factura.ToList();
                ConsultadataGridView.Columns[2].Visible = false;
                ConsultadataGridView.Columns[7].Visible = false;
                ConsultadataGridView.Columns[9].Visible = false;

            }
            catch
            {


            }
        }
    }
}
