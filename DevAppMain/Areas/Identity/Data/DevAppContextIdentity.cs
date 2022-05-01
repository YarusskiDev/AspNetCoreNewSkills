using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DevAppMain.ViewModels;
using Dev.Business.Models;

namespace DevAppMain.Areas.Identity.Data
{
    public class DevAppContextIdentity : IdentityDbContext<IdentityUser>
    {
        public DevAppContextIdentity(DbContextOptions<DevAppContextIdentity> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<DevAppMain.ViewModels.CarroViewModel> CarroViewModel { get; set; }

        public DbSet<DevAppMain.ViewModels.ClienteViewModel> ClienteViewModel { get; set; }

        public DbSet<DevAppMain.ViewModels.ConcessionariaViewModel> ConcessionariaViewModel { get; set; }

        public DbSet<Dev.Business.Models.Endereco> Endereco { get; set; }
    }
}
