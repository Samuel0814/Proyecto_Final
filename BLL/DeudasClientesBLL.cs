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


        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                DeudasClientes deudasClientes = contexto.deudas.Find(id);

               
                

                contexto.deudas.Remove(deudasClientes);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran deudas registradas en el ID seleccionado");
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
                MessageBox.Show("No se encuentran deudas registradas en el ID seleccionado");

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
                MessageBox.Show("No se encuentran deudas registradas");

            }
            return deudasClientes;
        }
    }
}
