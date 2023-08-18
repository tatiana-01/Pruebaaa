using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class Empleado
    {
        [Key]
        public int Id_Empleado {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string DNI {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string Cargo {get;set;}
        public ICollection<Registro_Entrega> Registro_Entregas {get;set;} 
        public ICollection<Registro_Devolucion> Registro_Devoluciones {get;set;} 
    }