using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Empleados
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Este campo es OBLIGATORIO")]
        [Required]
        public string Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }
        public String Departamento { get; set; }

        //[Required(ErrorMessage = "Este campo es OBLIGATORIO")]
        [Required]
        public String Cargo { get; set; }
        public String Fecha_Ingreso { get; set; }
        public int Salario { get; set; }
    }
}