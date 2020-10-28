using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class Sintoma
    {
        public int Id { get; set; }
        public int Fin_del_Periodo { get; set; }
        public int Días_de_Periodo { get; set; }
        public bool Pastillas { get; set; }
        public bool Inyecciones { get; set; }
        public string Otros_Cuidados { get; set; }
        public bool Acto_Sexual { get; set; }
        public string Sintomas { get; set; }
        public string Estado_de_Ánimo { get; set; }
        public string Notas { get; set; }

    }
}
