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
    public partial class ArticulosViewer : Form
    {
        private List<Articulos> articulos = null;
        public ArticulosViewer(List<Articulos> articulos)
        {
            this.articulos = articulos;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoArticulos listado = new ListadoArticulos();
            listado.SetDataSource(listado);
            crystalReportViewer1.ReportSource = listado;
            listado.Refresh();
        }
    }
}