using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades;
    public class Registro_Devolucion
    {
    [Key]
    public int Id_Registro { get; set; }
    public Alquiler Alquiler {get; set;}
    public int Id_Alquiler { get; set; }
    public Empleado Empleado { get; set; }
    public int Id_Empleado { get; set; }
    public DateTime Fecha_Devolucion { get; set; }
    public decimal Combustible_Devuelto { get; set; }
    public int Kilometraje_Devuelto { get; set; }
    public decimal Monto_Adicional { get; set; }
  
    }
