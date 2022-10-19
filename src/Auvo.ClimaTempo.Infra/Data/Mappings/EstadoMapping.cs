using Auvo.ClimaTempo.Business.Models.Estados;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Infra.Data.Mappings
{
    public class EstadoMapping : EntityTypeConfiguration<Estado>
    {
        public EstadoMapping()
        {
            HasKey(e => e.Id);

            Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(e => e.UF)
                .IsRequired()
                .HasMaxLength(2);

            ToTable("Estado");
        }
    }
}
