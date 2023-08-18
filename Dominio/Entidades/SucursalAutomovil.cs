using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class SucursalAutomovil
    {
        public Sucursal Sucursal { get; set; }
       public int Id_Sucursal { get; set; }
       public Automovil Automovil { get; set; }
       public int Id_Automovil { get; set; }
       public int Cantidad_Disponible { get; set; } 
    }
