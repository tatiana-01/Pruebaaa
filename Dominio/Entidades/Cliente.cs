using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class Cliente
    {
        [Key]
        public int Id_Cliente {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string DNI {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string Email {get;set;}
        public ICollection<Alquiler> Alquileres {get;set;} 
        public ICollection<Reserva> Reservas {get;set;} 
    }
