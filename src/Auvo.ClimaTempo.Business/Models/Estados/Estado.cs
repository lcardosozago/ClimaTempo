using Auvo.ClimaTempo.Business.Core.Models;
using Auvo.ClimaTempo.Business.Models.Cidades;
using System.Collections.Generic;

namespace Auvo.ClimaTempo.Business.Models.Estados
{
    public class Estado : Entity
    {
        public string Nome { get; set; }

        public string UF { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
