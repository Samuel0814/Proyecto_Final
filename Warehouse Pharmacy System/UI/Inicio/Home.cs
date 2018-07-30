using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse_Pharmacy_System.UI.Consultas;
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
            new ConsultaArticulos().Show();
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaUsuario().Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaCategorias().Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaFactura().Show();
        }

        private void deudasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaDeudas().Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroVenta().Show();
        }

        private void saldarDeudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SaldarDeudas().Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConsultaCliente().Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
