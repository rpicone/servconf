using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerConfWeb.Models;

namespace ServerConfWeb.Data
{
    public class ServerConfDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Servidor> Servidores { get; set; }

        public DbSet<Configuracao> Configuracoes { get; set; }

        public DbSet<Monitoramento> Monitoramentos { get; set; }

        public ServerConfDbContext(DbContextOptions<ServerConfDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}