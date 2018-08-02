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
                DeudasClientes clientDeuda=new DeudasClientes();
                clientDeuda.ClienteID = facturas.IdCliente;
                
                

                 if(facturas.ACredito)
                {
                    var deuda = contexto.deudas.Find(facturas.IdCliente);
                    if(deuda!=null)
                    {
                         deuda.Facturas.Add(facturas);
                       

                    }
                    else
                    {
                        clientDeuda.Facturas.Add(facturas);

                        contexto.deudas.Add(clientDeuda);

                    }
                    
                    
                }
                if (contexto.Facturas.Add(facturas) != null)
                {
                    foreach (var item in facturas.Detalle)
                    {
                     var articulo = contexto.articulos.Find(item.IdArticulo);
                     articulo.Existencia -= item.Cantidad;
                        
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

        public static bool Modificar(Facturas Factura)
        {
            bool paso = false;
            Factura.EstaSaldada = false;
            Contexto contexto = new Contexto();
            Facturas Tmp = contexto.Facturas.Find(Factura.IdFactura);
            DeudasClientes clientDeuda;
            if (Factura.ACredito&&Tmp.ACredito)
            {
               clientDeuda= contexto.deudas.Find(Factura.IdCliente);
               var fact=clientDeuda.Facturas.Find(x=>x.IdFactura ==Factura.IdFactura);
                fact = Factura;


            }
            else
               if(Factura.ACredito&& !Tmp.ACredito)
               {
                clientDeuda = new DeudasClientes();
                clientDeuda.ClienteID = Factura.IdCliente;
                

                clientDeuda.Facturas.Add(Factura);
                //contexto.deudas.Add(clientDeuda);
                var deuda = contexto.deudas.Find(Factura.IdCliente);
                if (deuda != null)
                {
                    deuda.Facturas.Add(Factura);


                }
                else
                {
                    clientDeuda.Facturas.Add(Factura);

                    contexto.deudas.Add(clientDeuda);

                }

            }
            try
            {
                int sum = 0;
                int sumTotal = 0;
                foreach (var item in Factura.Detalle)
                {
                    var estado = item.ID > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;

                    sum += item.Cantidad;
                    sumTotal += Convert.ToInt32(item.Importe);
                    contexto.articulos.Find(item.IdArticulo).Existencia -= sum;
                   
                }


                contexto.Entry(Factura).State = EntityState.Modified;


                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran facturas regitradas en el ID seleccionado");
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
                MessageBox.Show("No se encuentras facturas registradas en el ID seleccionado");
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

                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("No se encuentras detalles de facturas registradas en el ID Seleccionado");
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
