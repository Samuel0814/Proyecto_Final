using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse_Pharmacy_System.UI.Reportes
{
    public partial class ClienteViewer : Form
    {
        private List<Clientes> ListaCliente = null;
        public ClienteViewer(List<Clientes>clientes)
        {
            this.ListaCliente = clientes;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoClientes listado = new ListadoClientes();
            listado.SetDataSource(ListaCliente);
            crystalReportViewer1.ReportSource= listado;
            listado.Refresh();
        }
    }
}
