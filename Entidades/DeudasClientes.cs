using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DeudasClientes
    {
        [Key]
        public int IdDeudas { get; set; }
        public string Cliente { get; set; }
        public decimal Deuda { get; set; }


        public DeudasClientes()
        {


        }
        public DeudasClientes(int idDudas, string cliente, decimal deuda)
        {
            this.IdDeudas = idDudas;
            this.Cliente = cliente;
            this.Deuda = deuda;
        }
    }
}
