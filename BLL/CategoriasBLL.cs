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
    public class CategoriasBLL
    {
        public static bool Guardar(Categorias categorias)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.categoria.Add(categorias) != null)
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

        public static bool Modificar(Categorias categorias)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(categorias).State = EntityState.Modified;
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
                Categorias categorias = contexto.categoria.Find(id);

                contexto.categoria.Remove(categorias);

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


        public static Categorias Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Categorias categorias = new Categorias();
            try
            {
                categorias = contexto.categoria.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("No se encuentran categorias registradas");
            }
            return categorias;
        }


        public static List<Categorias> GetList(Expression<Func<Categorias, bool>> expression)
        {
            List<Categorias> vehiculos = new List<Categorias>();
            Contexto contexto = new Contexto();
            try
            {
                vehiculos = contexto.categoria.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran categorias registrados");
            }
            return vehiculos;
        }
    }
}
