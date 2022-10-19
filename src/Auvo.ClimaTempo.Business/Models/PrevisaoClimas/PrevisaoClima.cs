using Auvo.ClimaTempo.Business.Core.Models;
using Auvo.ClimaTempo.Business.Models.Cidades;
using System;

namespace Auvo.ClimaTempo.Business.Models.PrevisaoClimas
{
    public class PrevisaoClima : Entity
    {
        public DateTime DataPrevisao { get; set; }

        public string Clima { get; set; }

        public int TemperaturaMinima { get; set; }

        public int TemperaturaMaxima { get; set; }

        public int CidadeId { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}
