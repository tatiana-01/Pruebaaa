using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class Registro_Entrega
    {
        [Key]
        public int Id_Registro {get;set;}
        public Alquiler Alquiler { get; set; }
        public int Id_Alquiler {get;set;}
        public Empleado Empleado { get; set; }
        public int Id_Empleado {get;set;}
        public DateTime Fecha_Entrega { get; set; }
        public decimal Combustible_Entregado { get; set; }
        public int Kilometraje_Entregado { get; set; }

    }
