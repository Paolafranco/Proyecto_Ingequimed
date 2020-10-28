using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class DatoPersonal
    {
        public int Id { get; set; }
        public string Edad { get; set; }
        public bool Habitos { get; set; }
        public bool Patalogías { get; set; }
        public bool Alergias { get; set; }
        public bool Embarazos { get; set; }
        public bool Cesárea { get; set; }
        public bool Cirugías { get; set; }
    }
}
