using DAL;
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
    }
}
