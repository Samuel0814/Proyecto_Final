using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        public  enum Genero { Masculino, Femenino}
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public Genero Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Credito { get; set; }
        public decimal MaximoCredicto { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }

        public Clientes()
        {

        }

        public Clientes(int clienteId, string nombres, string direccion, string email, Genero sexo, DateTime fechaNacimiento, string cedula, decimal maximocredito)
        {
            this.Cedula = cedula;
            this.ClienteId = clienteId;
            this.Nombres = nombres;
            this.Direccion = direccion;
            this.Email = email;
            this.Sexo = sexo;
            this.FechaNacimiento = fechaNacimiento;
            this.MaximoCredicto = maximocredito;
        }
    }
}
