using Auvo.ClimaTempo.Business.Models.Cidades;
using Auvo.ClimaTempo.Business.Models.Estados;
using Auvo.ClimaTempo.Business.Models.PrevisaoClimas;
using Auvo.ClimaTempo.Infra.Data.Mappings;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Auvo.ClimaTempo.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClimas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new EstadoMapping());
            modelBuilder.Configurations.Add(new CidadeMapping());
            modelBuilder.Configurations.Add(new PrevisaoClimaMapping());
        }
    }
}
