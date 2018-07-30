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

namespace Warehouse_Pharmacy_System.UI.Consultas
{
    public partial class ConsultaFactura : Form
    {
        public ConsultaFactura()
        {
            InitializeComponent();
        }

        private void Llenar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "NombreArticulo");
            FiltrocomboBox.Items.Insert(2, "Todo");
        }

        private void ConsultaFactura_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

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
                case 1:
                    filtro = a => a.NombreUsuario.Contains(CriteriotextBox.Text) && a.FechaVenta >= DesdedateTimePicker.Value && a.FechaVenta <= HastadateTimePicker.Value;
                    break;

                case 2: //filtrando todos
                    Expression<Func<Facturas, bool>> filtro2 = a => true;
                    break;
            }

            ConsultadataGridView.DataSource = BLL.FacturaBLL.GetList(filtro);
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
    }
}