using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class Reserva
    {
        [Key]
        public int Id_Reserva { get; set; }
        public Cliente Cliente { get; set; }
        public int Id_Cliente { get; set; }
        public Automovil Automovil { get; set; }
        public int Id_Automovil { get; set; }
        public DateTime Fecha_Reserva { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string Estado { get; set; }
    }
