using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Ginecologia_Ingequimed.ViewModels
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Display(Name = "Su Fotografia")]
        public IFormFile FotografiaPerfil { get; set; }
    }
}