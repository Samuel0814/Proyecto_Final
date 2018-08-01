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
    public partial class DetalleViewer : Form
    {
        private List<FacturasDetalles> facturas = null;
        public DetalleViewer(List<FacturasDetalles> clientes)
        {
            this.facturas = clientes;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoDetalle listado = new ListadoDetalle();
            listado.SetDataSource(listado);
            crystalReportViewer1.ReportSource = listado;
            listado.Refresh();
        }
    }
}