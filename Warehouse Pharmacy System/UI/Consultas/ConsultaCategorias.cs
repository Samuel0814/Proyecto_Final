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
    public partial class ConsultaCategorias : Form
    {
        private List<Categorias> categorias;
        public ConsultaCategorias()
        {
            InitializeComponent();
        }

        private void Llenar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "NombreCategoria");
            FiltrocomboBox.Items.Insert(2, "Todo");
        }

        private void Buscatbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Categorias, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.CategoriaId == id;
                    break;
                case 1:
                    filtro = a => a.NombreCategoria.Contains(CriteriotextBox.Text);
                    break;

                case 2: //filtrando todos
                    Expression<Func<Categorias, bool>> filtro2 = a => true;
                    break;
            }
            categorias = BLL.CategoriasBLL.GetList(filtro);
            ConsultadataGridView.DataSource = categorias;
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

        private void ConsultaCategorias_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void Imprimirbutton_Click_1(object sender, EventArgs e)
        {
            if (categorias.Count == 0)
            {
                MessageBox.Show("Reporte esta vacio");
                return;
            }
            CategoriasViewer clienteViewer = new CategoriasViewer(categorias);
            clienteViewer.Show();
        }
    }
}
