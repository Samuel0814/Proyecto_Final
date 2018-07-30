using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> articulos { get; set; }
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Categorias> categoria { get; set; }
        public DbSet<FacturasDetalles> DetalleFactura  { get; set; }
        public DbSet<Facturas> Facturas { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}

