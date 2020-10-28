using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ginecologia_Ingequimed.Models;

namespace Ginecologia_Ingequimed.Data
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public DbSet<Ginecologia_Ingequimed.Models.Calendario> Calendario { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.DatoFamiliar> DatoFamiliar { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.DatoPersonal> DatoPersonal { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.Materno> Materno { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.Pareja> Pareja { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.Paterno> Paterno { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.Salud> Salud { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.Sintoma> Sintoma { get; set; }

        public DbSet<Ginecologia_Ingequimed.Models.Enfermedades> Enfermedades { get; set; }
    }
}
