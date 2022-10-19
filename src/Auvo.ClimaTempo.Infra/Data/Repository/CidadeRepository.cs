using Auvo.ClimaTempo.Business.Data.Dtos;
using Auvo.ClimaTempo.Business.Models.Cidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Infra.Data.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public Task<List<CidadeComEstadoDto>> ObterCidadesComEstados()
        {
            return Db.Cidades.Select(c => new CidadeComEstadoDto
            {
                CidadeId = c.Id,
                EstadoId = c.EstadoId,
                CidadeNome = c.Nome,
                UF = c.Estado.UF
            }).ToListAsync();
        }
    }
}
