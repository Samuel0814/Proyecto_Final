using BLL;
using Entidades;
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
            Permisos();
        }

        private void Permisos()
        {
            switch(UsuariosBLL.UsuarioLogueado.Tipo)
            {
                case "Administrador":
                    registroDeArticulosToolStripMenuItem.Enabled = true;
                    usuarioToolStripMenuItem.Enabled = true;
                    CategoriaToolStripMenuItem.Enabled = true;
                    clientesToolStripMenuItem.Enabled = true;
                    saldarDeudasToolStripMenuItem1.Enabled = true;
                    usuariosToolStripMenuItem.Enabled = true;
                    
                    break;
                case "Empleado":

                    break;
            }
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
            RegistroArticulos r = new RegistroArticulos();
            r.MdiParent = this;
            r.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCategorias r = new RegistroCategorias();
            r.MdiParent = this;
            r.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios r = new RegistroUsuarios();
            r.MdiParent = this;
            r.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes r = new RegistroClientes();
            r.MdiParent = this;
            r.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaArticulos r = new ConsultaArticulos();
            r.MdiParent = this;
            r.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ConsultaUsuario().Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCategorias r = new ConsultaCategorias();
            r.MdiParent = this;
            r.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFactura r = new ConsultaFactura();
            r.MdiParent = this;
            r.Show();
        }

        private void deudasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDeudas r = new ConsultaDeudas();
            r.MdiParent = this;
            r.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCliente r = new ConsultaCliente();
            r.MdiParent = this;
            r.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroVenta r = new RegistroVenta();
            r.MdiParent = this;
            r.Show();
        }

        private void saldarDeudasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PagoFactura r = new PagoFactura();
            r.MdiParent = this;
            r.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultaUsuario r = new ConsultaUsuario();
            r.MdiParent = this;
            r.Show();
        }
    }
}
