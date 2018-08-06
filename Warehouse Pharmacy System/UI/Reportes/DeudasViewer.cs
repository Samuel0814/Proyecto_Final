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
    public partial class DeudasViewer : Form
    {
        private List<DeudasClientes> deudasClientes = null;
        public DeudasViewer(List<DeudasClientes>lista)
        {
            this.deudasClientes = lista;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoDeudas listado = new ListadoDeudas();
            listado.SetDataSource(deudasClientes);
            crystalReportViewer1.ReportSource = listado;
            crystalReportViewer1.Refresh();
        }
    }
}