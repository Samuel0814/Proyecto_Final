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
    public class ArticuloBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.articulos.Add(articulo) != null)
                {
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

        public static bool Modificar(Articulos articulo)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
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

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Articulos articulo = contexto.articulos.Find(id);

                contexto.articulos.Remove(articulo);

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

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulo = new Articulos();
            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran  articulos registradas en el ID seleccionado");

            }
            return articulo;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran articulos registradas");

            }
            return articulos;
        }
    }
}
