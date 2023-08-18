using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class Alquiler
    {
        [Key]
        public int Id_Alquiler { get; set; }
        public Cliente Cliente { get; set; }
        public int Id_Cliente { get; set; }
        public Automovil Automovil { get; set; }
        public int Id_Automovil { get; set;}
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public decimal Costo_Total  { get; set; }
        public string Estado { get; set; }
        public ICollection<Registro_Devolucion> Registro_Devoluciones {get;set;} 
        public ICollection<Registro_Entrega> Registro_Entregas {get;set;} 
    }