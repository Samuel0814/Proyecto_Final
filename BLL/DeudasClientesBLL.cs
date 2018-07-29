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
        public static bool Guardar(DeudasClientes deudas)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.deudas.Add(deudas) != null)
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

        public static bool Modificar(DeudasClientes deudas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(deudas).State = EntityState.Modified;
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
                DeudasClientes deudas = contexto.deudas.Find(id);

                contexto.deudas.Remove(deudas);

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


        public static DeudasClientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            DeudasClientes deudas = new DeudasClientes();
            try
            {
                deudas = contexto.deudas.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("No se encuentran categorias registradas");
            }
            return deudas;
        }


        public static List<DeudasClientes> GetList(Expression<Func<DeudasClientes, bool>> expression)
        {
            List<DeudasClientes> deudas = new List<DeudasClientes>();
            Contexto contexto = new Contexto();
            try
            {
                deudas = contexto.deudas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran categorias registrados");
            }
            return deudas;
        }
    }
}
