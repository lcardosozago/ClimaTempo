using System;

namespace Auvo.ClimaTempo.Business.Data.Dtos
{
    public class CidadeComEstadoClimaDto
    {
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public string CidadeNome { get; set; }
        public string UF { get; set; }
        public string Clima { get; set; }
        public DateTime DataPrevisao { get; set; }
        public int TemperaturaMinima { get; set; }
        public int TemperaturaMaxima { get; set; }
    }
}
