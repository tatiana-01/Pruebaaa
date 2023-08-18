using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using iText.Commons.Actions;

namespace Dominio.Entidades;
    public class Sucursal
    {
        [Key]
        public int Id_Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public ICollection<SucursalAutomovil> SucursalAutomoviles { get; set; }
    }
