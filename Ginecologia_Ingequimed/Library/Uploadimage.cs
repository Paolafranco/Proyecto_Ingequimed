using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Ginecologia_Ingequimed.Library
{
    public class Uploadimage
    {
        public async Task<byte[]> ByteAvatarImageAsync(IFormFile AvatarImage, IWebHostEnvironment environment)
        {
            string image = "images/images/user1.png";
            if (AvatarImage != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await AvatarImage.CopyToAsync(memoryStream);
                    return memoryStream.ToArray();
                }
            }
            else
            {
                var archivoOrigen = $"{environment.ContentRootPath}/wwwroot/{image}";
                return File.ReadAllBytes(archivoOrigen);
            }
        }
    }
}