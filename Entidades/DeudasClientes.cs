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
        public int IdFactura { get; set; }


        public DeudasClientes()
        {
            

        }
       
       
    }
}
