using Auvo.ClimaTempo.Business.Core.Data;
using Auvo.ClimaTempo.Business.Data.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Business.Models.PrevisaoClimas
{
    public interface IPrevisaoClimaRepository : IRepository<PrevisaoClima>
    {
        Task<List<CidadeComEstadoClimaDto>> ObterPrevisaoClimaDosProximosSeteDiasPorCidadeId(int cidadeId);
        Task<List<CidadeComEstadoClimaDto>> ObterTresCidadesMaisQuentes();
        Task<List<CidadeComEstadoClimaDto>> ObterTresCidadesMaisFrias();
    }
}
