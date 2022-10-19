using Auvo.ClimaTempo.Business.Models.PrevisaoClimas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Infra.Data.Mappings
{
    public class PrevisaoClimaMapping : EntityTypeConfiguration<PrevisaoClima>
    {
        public PrevisaoClimaMapping()
        {
            HasKey(p => p.Id);

            Property(p => p.DataPrevisao)
                .IsRequired();

            Property(p => p.Clima)
                .IsRequired()
                .HasMaxLength(15);

            Property(p => p.TemperaturaMinima)
                .IsOptional();

            Property(p => p.TemperaturaMaxima)
                .IsOptional();

            Property(p => p.CidadeId)
                .IsRequired();

            HasRequired(p => p.Cidade)
                .WithMany(c => c.PrevisaoClimas)
                .HasForeignKey(f => f.CidadeId);

            ToTable("PrevisaoClima");
        }
    }
}
