using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int IdFactura { get; set; }
        public enum  Tipo {Credito,contado }

        public string NombreUsuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public int ClienteId { get; set; }
        public Tipo Tipoventa { get; set; }
        public int CantidadProd { get; set; }
        public decimal Total { get; set; }



        public Facturas()
        {

        }
        public Facturas(int idFactura, string nombreUsuario, DateTime fechaVenta, int cliente, Tipo tipoventa, int cantidadProd, decimal total)
        {
            this.IdFactura = idFactura;
            this.NombreUsuario = nombreUsuario;
            this.FechaVenta = fechaVenta;
            this.ClienteId = cliente;
            this.Tipoventa = tipoventa;
            this.CantidadProd = cantidadProd;
            this.Total = total;

        }
    }
}
