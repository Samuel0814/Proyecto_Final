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
    public partial class CategoriasViewer : Form
    {
        private List<Categorias> categorias = null;
        public CategoriasViewer(List<Categorias> categorias)
        {
            this.categorias = categorias;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoCategorias listado = new ListadoCategorias();
            listado.SetDataSource(listado);
            crystalReportViewer1.ReportSource = listado;
            listado.Refresh();
        }
    }
}
