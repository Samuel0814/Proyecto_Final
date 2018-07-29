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
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.clientes.Add(cliente) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Guardar");
            }
            return paso;
        }

        public static bool Modificar(Clientes clientes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(clientes).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar");
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Clientes cliente = contexto.clientes.Find(id);

                contexto.clientes.Remove(cliente);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar");
            }
            return paso;
        }


        public static Clientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Clientes cliente = new Clientes();
            try
            {
                cliente = contexto.clientes.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("No se encuentran categorias registradas");
            }
            return cliente;
        }


        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            List<Clientes> cliente = new List<Clientes>();
            Contexto contexto = new Contexto();
            try
            {
                cliente = contexto.clientes.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran categorias registrados");
            }
            return cliente;
        }
    }
}
