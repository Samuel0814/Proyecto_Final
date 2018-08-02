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
        public int ClienteID { get; set; }
        public List<Facturas> Facturas { get; set; }


        public DeudasClientes()
        {


        }
       
        public float DeudaTotal()
        {
            float deuda = 0;
            foreach(Facturas item in Facturas)
            {
                deuda += item.Total;
            }

            return deuda;
        }
    }
}
