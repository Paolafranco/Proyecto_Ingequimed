using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class DatoFamiliar
    {
        public int Id { get; set; }
        public byte[] ImagenProducto { get; set; }
        [NotMapped]
        [Display(Name = "Fotografía")]
        public string FotoBase64 { get; set; }
    }
}
