using Auvo.ClimaTempo.Business.Core.Models;
using Auvo.ClimaTempo.Business.Models.Estados;
using Auvo.ClimaTempo.Business.Models.PrevisaoClimas;
using System.Collections.Generic;

namespace Auvo.ClimaTempo.Business.Models.Cidades
{
    public class Cidade : Entity
    {
        public string Nome { get; set; }

        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual ICollection<PrevisaoClima> PrevisaoClimas { get; set; }
    }
}
