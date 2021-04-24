using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ginecologia_Ingequimed.ViewModel
{
    public class DatosViewModel
    {
        public int Id_Producto { get; set; }
        public String Nombre { get; set; }

        public double Precio { get; set; }
        [Display(Name = "Fotografía")]
        public IFormFile ImagenProducto { get; set; }
    }
}
