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
using Warehouse_Pharmacy_System.UI.Reportes;

namespace Warehouse_Pharmacy_System.UI.Consultas
{
    public partial class ConsultaFactura : Form
    {
        private List<Facturas> facturas;
        public ConsultaFactura()
        {
            InitializeComponent();
        }

        private void Llenar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Todo");
        }

        private void ConsultaFactura_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (facturas.Count == 0)
            {
                MessageBox.Show("Reporte esta vacio");
                return;
            }
            FacturaViewer clienteViewer = new FacturaViewer(facturas);
            clienteViewer.Show();
        }

        private void Buscatbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Facturas, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.IdFactura == id && a.FechaVenta >= DesdedateTimePicker.Value && a.FechaVenta <= HastadateTimePicker.Value; ;
                    break;

                case 1: //filtrando todos
                    Expression<Func<Facturas, bool>> filtro2 = a => true;
                    break;
            }

            facturas = BLL.FacturaBLL.GetList(filtro);
            ConsultadataGridView.DataSource = facturas;
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 1)
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
    }
}