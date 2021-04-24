using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Ginecologia_Ingequimed.Models
{
    public class DatoFamiliar
    {
        public int Id { get; set; }

        [NotMapped]
        [DisplayName("Imagen Cargada")]
        public IFormFile ImageFile { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Fotografia")]
        public string ImageName { get; set; }
    }
}
