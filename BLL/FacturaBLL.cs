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
    public class FacturaBLL
    {
        public static bool Guardar(Facturas facturas)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Facturas.Add(facturas) != null)
                {
                    foreach (var item in facturas.Detalle)
                    {
                     var articulo = contexto.articulos.Find(item.IdArticulo);
                     articulo.Existencia -= item.Cantidad;
                        ////if ()
                        ////{
                        ////    var Cliente = contexto.clientes.Find(item.ClienteId);
                        ////    clientes.TotalMantenimiento += Convert.ToInt32(item.Importe);
                        ////}
                     
                        
                    }
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

        public static bool Modificar(Facturas mantenimientoDetalle)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                int sum = 0;
                int sumTotal = 0;
                foreach (var item in mantenimientoDetalle.Detalle)
                {
                    var estado = item.ID > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;

                    //TODO:
                    sum += item.Cantidad;
                    sumTotal += Convert.ToInt32(item.Importe);
                    contexto.articulos.Find(item.IdArticulo).Existencia -= sum;
                    //contexto.Clientes.Find(item.ClienteID).Deuda = int.Parse(sumTotal.ToString());
                }


                contexto.Entry(mantenimientoDetalle).State = EntityState.Modified;


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
                Facturas facturas = contexto.Facturas.Find(id);


                foreach (var item in facturas.Detalle)
                {
                    var articulo = contexto.articulos.Find(item.IdArticulo);
                    articulo.Existencia += item.Cantidad;
                    //var cliente = contexto.clientes.Find(item.IdCliente);
                    //cliente.Credito -= Convert.ToInt32(item.Importe);


                }
                contexto.Facturas.Remove(facturas);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentras facturas registrados en el ID seleccionado");
            }
            return paso;
        }



        public static Facturas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Facturas facturas = new Facturas();
            try
            {
                facturas = contexto.Facturas.Find(id);

                facturas.Detalle.Count();

                foreach (var item in facturas.Detalle)
                {
                    string s = item.Articulos.NombreArticulo;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("No se encuentras detalles de facturas registrados en el ID Seleccionado");
            }
            return facturas;
        }

        public static List<Facturas> GetList(Expression<Func<Facturas, bool>> expression)
        {
            List<Facturas> facturas = new List<Facturas>();
            Contexto contexto = new Contexto();
            try
            {
                facturas = contexto.Facturas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentras facturas registrados");
            }
            return facturas;
        }
    }
}
