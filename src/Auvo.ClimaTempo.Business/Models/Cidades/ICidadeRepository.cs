using Auvo.ClimaTempo.Business.Core.Data;
using Auvo.ClimaTempo.Business.Data.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Business.Models.Cidades
{
    public interface ICidadeRepository : IRepository<Cidade>
    {
        Task<List<CidadeComEstadoDto>> ObterCidadesComEstados();
    }
}
