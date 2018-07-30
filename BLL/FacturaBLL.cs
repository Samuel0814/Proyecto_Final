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

        public static bool Guardar(Facturas factura)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Facturas.Add(factura) != null)
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

        public static bool  Guardar(Facturas factura, List<FacturasDetalles> detalles)
        {
            try
            {
                Contexto contexto = new Contexto();
                contexto.Facturas.Add(factura);
                foreach (FacturasDetalles detalle in detalles)
                {
                    contexto.DetalleFactura.Add(detalle);
                    contexto.articulos.Find(detalle.IdArticulo).Existencia -= detalle.Cantidad;

                }
                if(factura.Tipoventa==Facturas.Tipo.Credito)
                {
                    Clientes tmp = contexto.clientes.Find(factura.ClienteId);
                    tmp.Credito =tmp.Credito + factura.Total;


                }
                contexto.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public static bool Modificar(Facturas   facturas)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            Facturas tmpFactura = contexto.Facturas.Find(facturas.IdFactura);
            Clientes cliente = contexto.clientes.Find(facturas.ClienteId);
            if (tmpFactura.Tipoventa == Facturas.Tipo.Credito)
            {
                Clientes tmpCliente = contexto.clientes.Find(tmpFactura.ClienteId);
                tmpCliente.Credito = tmpCliente.Credito - tmpFactura.Total;


            }
            
            try
            {
                contexto.Entry(facturas).State = EntityState.Modified;
                if (facturas.Tipoventa == Facturas.Tipo.Credito)
                {
                    Clientes tmp = contexto.clientes.Find(facturas.ClienteId);
                    tmp.Credito = tmp.Credito + facturas.Total;


                }
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
                Facturas factura = contexto.Facturas.Find(id);

                contexto.Facturas.Remove(factura);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

                if (factura.Tipoventa == Facturas.Tipo.Credito)
                {
                    Clientes tmp = contexto.clientes.Find(factura.ClienteId);
                    tmp.Credito = tmp.Credito - factura.Total;


                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran facturas registradas en el ID seleccionado");
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
                MessageBox.Show("No se encuentran  facturas registradas en el ID seleccionado");

            }
            return articulo;
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
                MessageBox.Show("No se encuentran facturas registradas");

            }
            return facturas;
        }
    }
}
