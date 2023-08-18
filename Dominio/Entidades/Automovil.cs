using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class Automovil
    {
        [Key]
        public int Id_Automovil { get; set; }
        public string Marca { get; set; }   
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public decimal Precio_Diario { get; set; }
        public ICollection<Alquiler> Alquileres {get;set;} 
        public ICollection<Reserva> Reservas {get;set;} 
        public ICollection<SucursalAutomovil> SucursalAutomoviles { get; set; }
    }
