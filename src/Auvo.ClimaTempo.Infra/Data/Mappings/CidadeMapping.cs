using Auvo.ClimaTempo.Business.Models.Cidades;
using Auvo.ClimaTempo.Business.Models.Estados;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Infra.Data.Mappings
{
    public class CidadeMapping : EntityTypeConfiguration<Cidade>
    {
        public CidadeMapping()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.EstadoId)
                .IsRequired();

            HasRequired(c => c.Estado)
                .WithMany(e => e.Cidades)
                .HasForeignKey(f => f.EstadoId);

            ToTable("Cidade");
        }
    }
}
