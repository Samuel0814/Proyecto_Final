using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class DeudasClientesBLL
    {
        public static bool Guardar(DeudasClientes nuevo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.deudas.Add(nuevo) != null)
                {
                    Clientes clientes = contexto.clientes.Find(nuevo.ClienteID);
                    clientes.Credito -= nuevo.Deuda;

                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
            return paso;

        }

        public static bool Mofidicar(DeudasClientes existente, DeudasClientes EntradaAnterior)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                DeudasClientes entrada = BLL.DeudasClientesBLL.Buscar(existente.IdDeudas);

                contexto.Entry(existente).State = EntityState.Modified;

                Clientes clientes = contexto.clientes.Find(existente.IdDeudas);
                Clientes ArticuloAnterior = contexto.clientes.Find(EntradaAnterior.ClienteID);
                clientes.Credito += existente.Deuda;
                ArticuloAnterior.Credito -= EntradaAnterior.Deuda;

                contexto.Entry(clientes).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran Articulos regitrados en el ID seleccionado");

            }
            return paso;

        }

        public static bool Eliminar(DeudasClientes id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                DeudasClientes deudasClientes = contexto.deudas.Find(id);

                Clientes clientes = contexto.clientes.Find(deudasClientes.ClienteID);
                clientes.Credito += deudasClientes.Deuda;

                contexto.deudas.Remove(deudasClientes);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran entradas de articulos registradas en el ID seleccionado");
            }
            return paso;
        }

        public static DeudasClientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            DeudasClientes deuda = new DeudasClientes();
            try
            {
                deuda = contexto.deudas.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran  articulos registradas en el ID seleccionado");

            }
            return deuda;
        }

        public static List<DeudasClientes> GetList(Expression<Func<DeudasClientes, bool>> expression)
        {
            List<DeudasClientes> deudasClientes = new List<DeudasClientes>();
            Contexto contexto = new Contexto();
            try
            {
                deudasClientes = contexto.deudas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran articulos registradas");

            }
            return deudasClientes;
        }
    }
}
