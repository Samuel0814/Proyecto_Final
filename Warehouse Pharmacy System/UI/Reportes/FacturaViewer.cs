﻿using Entidades;
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
    public partial class FacturaViewer : Form
    {
        private List<Facturas> facturas = null;
        public FacturaViewer(List<Facturas> lista)
        {
            this.facturas = lista;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoFacturas listado = new ListadoFacturas();
            listado.SetDataSource(facturas);
            crystalReportViewer1.ReportSource = listado;
            crystalReportViewer1.Refresh();
        }
    }
}