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
                clientDeuda.IdFactura = facturas.IdFactura;
                



                if (facturas.ACredito)
                {
                    if (TieneCreditoDisponile(facturas))
                    {
                        var deuda = contexto.deudas.Find(facturas.IdCliente);
                        contexto.deudas.Add(clientDeuda);

                        
                    }else
                    {
                        MessageBox.Show("Este cliente no tiene Credito disponible");
                        return false;
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paso;
        }

        private static bool TieneCreditoDisponile(Facturas factura)
        {
            Contexto db = new Contexto();
            var client = db.clientes.Find(factura.IdCliente);
            if(client.MaximoCredicto < decimal.Parse(factura.Total.ToString()))
            {

                return false;
            }
            var Deudas = from f in db.Facturas
                         join d in db.Facturas on f.IdFactura equals factura.IdFactura
                         where f.IdCliente== client.ClienteId 
                         select f;
            foreach (var item in Deudas )
            {
               
                    
                    if(item.FechaExpiracion<DateTime.Now)
                    {
                        MessageBox.Show("Este cliente tiene factura pendinete");
                        return false;
                    }

                
            }


            return true;
        }

        public static bool Modificar(Facturas Factura)
        {
            bool paso = false;
            Factura.EstaSaldada = false;
            Contexto contexto = new Contexto();
            Facturas Tmp = contexto.Facturas.Find(Factura.IdFactura);
            DeudasClientes clientDeuda;
            if (Factura.ACredito && Tmp.ACredito)
            {

            }
            else
            {
                if (Factura.ACredito && !Tmp.ACredito)
                {
                    clientDeuda = new DeudasClientes();
                    clientDeuda.IdFactura = Factura.IdFactura;
                    contexto.deudas.Add(clientDeuda);
                }
                else
                {
                    if (!Tmp.ACredito&&Factura.ACredito)
                    {
                        DeudasClientes deudacliente = (from d in contexto.deudas
                                                      where d.IdFactura == Factura.IdFactura
                                                      select d).First();
                        contexto.deudas.Remove(deudacliente);
                    }
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


               
                Facturas tmpfact =contexto.Facturas.Find(Factura.IdFactura);
                tmpfact.IdCliente = Factura.IdCliente;
                tmpfact.Detalle = Factura.Detalle;
                tmpfact.Itbis = Factura.Itbis;
                tmpfact.Total = Factura.Total;
                tmpfact.SubTotal = Factura.SubTotal;
                tmpfact.FechaVenta = Factura.FechaVenta;
                tmpfact.FechaExpiracion = tmpfact.FechaVenta.AddDays(30);
                tmpfact.ACredito = Factura.ACredito;
                //contexto.Entry(tmpfact).State = EntityState.Modified;

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
        public static bool EliminarDetalleFactura(FacturasDetalles detalle)
        {
            Contexto db = new Contexto();
            try
            {

                var articulo = db.articulos.Find(detalle.IdArticulo);
                articulo.Existencia += detalle.Cantidad;
                db.DetalleFactura.Remove(detalle);
                db.SaveChanges();
               

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            return true;
        }
    }
}
