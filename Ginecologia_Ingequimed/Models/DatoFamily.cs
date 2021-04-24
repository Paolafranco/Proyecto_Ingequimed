using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.Models
{
    public class DatoFamily
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
        public byte[] FotografiaPerfil { get; set; }

        [NotMapped]
        public string fotografiaBase64 { get; set; }
    }
}
