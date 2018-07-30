﻿using System;
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
        public DateTime FechaVenta { get; set; }
        public float SubTotal { get; set; }
        public float Itbis { get; set; }
        public float Total { get; set; }

        public virtual ICollection<FacturasDetalles> Detalle { get; set; }

        public Facturas()
        {
            this.Detalle = new List<FacturasDetalles>();
        }
        public void AgregarFacturas(int id, int idFactura, int ArticuloId, int idCliente, int Cantidad, float precio, float importe)
        {
            this.Detalle.Add(new FacturasDetalles(id,idFactura, ArticuloId, idCliente ,Cantidad, precio, importe));
        }
    }
}
