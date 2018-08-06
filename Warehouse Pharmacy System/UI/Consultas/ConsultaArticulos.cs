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
    public partial class ConsultaArticulos : Form
    {
        private List<Articulos> datos;
        public ConsultaArticulos()
        {
            InitializeComponent();
        }

        private void Llenar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "NombreArticulo");
            FiltrocomboBox.Items.Insert(2, "Fecha");
            FiltrocomboBox.Items.Insert(3, "Todo");
        }

        private void Buscatbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.CategoriaId == id && a.FechaIngreso >= DesdedateTimePicker.Value && a.FechaIngreso <= HastadateTimePicker.Value; ;
                    break;
                case 1:
                    filtro = a => a.NombreArticulo.Contains(CriteriotextBox.Text) && a.FechaIngreso >= DesdedateTimePicker.Value && a.FechaIngreso <= HastadateTimePicker.Value;
                    break;

                case 2:
                    filtro = a => a.FechaIngreso >= DesdedateTimePicker.Value.Date && a.FechaIngreso <= HastadateTimePicker.Value.Date;
                     break;
                case 3: //filtrando todos
                    Expression<Func<Articulos, bool>> filtro2 = a => true;
                    break;
            }

            datos = BLL.ArticuloBLL.GetList(filtro);
            ConsultadataGridView.DataSource = datos;
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 2 && FiltrocomboBox.SelectedIndex ==3)
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

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(datos.Count == 0)
            {
                MessageBox.Show("Reporte esta vacio");
                return;
            }
            ArticulosViewer articulosViewer = new ArticulosViewer(datos);
            articulosViewer.Show();
        }

        private void ConsultaArticulos_Load(object sender, EventArgs e)
        {
            Llenar();
        }
    }
}