using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturasDetalles
    {
        [Key]
        public int ID { get; set; }
        public int IdFactura { get; set; }
        public int IdArticulo { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Importe { get; set; }
        //public Entidades.Articulos Articulo { get; set; }

        //[ForeignKey("ClientesId")]
        //public virtual Clientes Clientes { get; set; }

        //[ForeignKey("IdArticulo")]
        //public virtual Articulos Articulos { get; set; }

        public FacturasDetalles()
        {
            this.ID = 0;
            this.IdFactura = 0;
            this.IdArticulo = 0;
            this.IdUsuario = 0;
            this.IdCliente = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Importe = 0;
        }

        public FacturasDetalles(int id, int idFactura,  int ArticuloId, int idCliente ,int Cantidad, float precio,float importe)
        {
            this.ID = id;
            this.IdFactura = idFactura;
            this.IdUsuario = IdUsuario;
            this.IdCliente = IdCliente;
            this.IdArticulo = IdArticulo;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
            this.Importe = importe;
        }
    }
}
