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
    public partial class ConsultaCliente : Form
    {
        private List<Clientes> ListaCliente;
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void Llenar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "NombreCategoria");
            FiltrocomboBox.Items.Insert(2, "Todo");
        }


        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (ListaCliente.Count == 0)
            {
                MessageBox.Show("Reporte esta vacio");
                return;
            }
            ClienteViewer clienteViewer = new ClienteViewer(ListaCliente);
            clienteViewer.Show();
            
        }

        private void Buscatbutton_Click_1(object sender, EventArgs e)
        {
            Expression<Func<Clientes, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.ClienteId == id;
                    break;
                case 1:
                    filtro = a => a.Nombres.Contains(CriteriotextBox.Text);
                    break;

                case 2: //filtrando todos
                    Expression<Func<Clientes, bool>> filtro2 = a => true;
                    break;
            }
            ListaCliente = BLL.ClientesBLL.GetList(filtro);
            ConsultadataGridView.DataSource = ListaCliente;
        }

        private void FiltrocomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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
