using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class Calendario
    {
        public int Id { get; set; }
        [Range(1, 31,
        ErrorMessage = "Ingrese bien sus datos del 1 al 31")]
        public int Día { get; set; }
        [Required]
        public string Mes { get; set; }
        [Range(2021, 2022,
        ErrorMessage = "Ingrese bien sus datos del 2021 al 2022")]
        public string Año { get; set; }
        public string Hora { get; set; }
    }
}
