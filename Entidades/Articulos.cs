using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Articulos
    {
        [Key]
        public int IdArticulo { get; set; }
        public String NombreArticulo { get; set; }
        public int Existencia { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CategoriaId { get; set; }
        public decimal ITBIS { get; set; }




        public Articulos()
        {


        }


        public Articulos(int idArticulo, string nombreArticulo, int existencia, decimal precioVenta, decimal precioCompra, DateTime fechaIngreso, decimal itbs)
        {
            this.IdArticulo = idArticulo;
            this.NombreArticulo = nombreArticulo;
            this.Existencia = existencia;
            this.PrecioVenta = precioVenta;
            this.PrecioCompra = precioCompra;
           
            
            this.FechaIngreso = fechaIngreso;
            this.ITBIS = itbs;
        }
    }
}
