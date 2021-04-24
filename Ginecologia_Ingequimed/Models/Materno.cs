using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class Materno
    {
        public int Id { get; set; }
        [Required]
        public string Nombre_Pariente { get; set; }
        [Required]
        public string Parentesco { get; set; }
        [Required]
        public string Enfermedad { get; set; }
    }
}
