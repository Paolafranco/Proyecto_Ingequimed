using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class Calendario
    {
        public int Id { get; set; }
        public int Día { get; set; }
        public int Mes { get; set; }
        public string Año { get; set; }
        public string Hora { get; set; }
    }
}
