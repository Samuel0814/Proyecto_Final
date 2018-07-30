﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse_Pharmacy_System.UI.Registros;

namespace Warehouse_Pharmacy_System.UI.Inicio
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void entradaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registroDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroArticulos().Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroCategorias().Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroUsuarios().Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroClientes().Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Seguro que desea salir de la aplicacion?",
            //           "Consulta",
            //           MessageBoxButtons.YesNo,
            //           MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                       
            //{
            //    e.Cancel = true; //Cancela el cerrado del formulario
            //}
           Application.Exit();
        }
    }
}