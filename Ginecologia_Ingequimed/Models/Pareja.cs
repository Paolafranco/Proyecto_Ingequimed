using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class Pareja
    {
        public int Id { get; set; }
        public bool Enfermedades { get; set; }
        public bool Anticonceptivo { get; set; }
        public bool Impotencia { get; set; }
        public bool Ets { get; set; }
        public bool HIV { get; set; }
        public bool Hvp { get; set; }
        public bool Gonorrea { get; set; }
        public bool Otros { get; set; }
        public string NombreEnfermedades { get; set; }
        public string NombreAnticonceptivo { get; set; }
    }
}
