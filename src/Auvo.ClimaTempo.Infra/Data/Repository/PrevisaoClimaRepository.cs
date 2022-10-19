using Auvo.ClimaTempo.Business.Data.Dtos;
using Auvo.ClimaTempo.Business.Models.PrevisaoClimas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Infra.Data.Repository
{
    public class PrevisaoClimaRepository : Repository<PrevisaoClima>, IPrevisaoClimaRepository
    {
        public async Task<List<CidadeComEstadoClimaDto>> ObterPrevisaoClimaDosProximosSeteDiasPorCidadeId(int cidadeId)
        {
            var climaDosProximosSeteDias = await Db.PrevisaoClimas.Where(
                p => p.CidadeId == cidadeId
                && p.DataPrevisao > DateTime.Now
            )
            .OrderBy(p => p.DataPrevisao)
            .Take(7)
            .Select(p => new CidadeComEstadoClimaDto
            {
                CidadeId = p.CidadeId,
                EstadoId = p.Cidade.EstadoId,
                CidadeNome = p.Cidade.Nome,
                UF = p.Cidade.Estado.UF,
                Clima = p.Clima,
                DataPrevisao = p.DataPrevisao,
                TemperaturaMinima = p.TemperaturaMinima,
                TemperaturaMaxima = p.TemperaturaMaxima
            })
            .ToListAsync();

            return climaDosProximosSeteDias;
        }

        public async Task<List<CidadeComEstadoClimaDto>> ObterTresCidadesMaisQuentes()
        {
            var callDateTime = DateTime.Now;

            var tresCidadesMaisQuentes = await Db.PrevisaoClimas
                .Where(p => DbFunctions.TruncateTime(p.DataPrevisao) == callDateTime.Date)
                .OrderByDescending(p => p.TemperaturaMaxima)
                .Take(3)
                .Select(p => new CidadeComEstadoClimaDto
                {
                    CidadeId = p.CidadeId,
                    EstadoId = p.Cidade.EstadoId,
                    CidadeNome = p.Cidade.Nome,
                    UF = p.Cidade.Estado.UF,
                    Clima = p.Clima,
                    DataPrevisao = p.DataPrevisao,
                    TemperaturaMinima = p.TemperaturaMinima,
                    TemperaturaMaxima = p.TemperaturaMaxima
                })
                .ToListAsync();

            return tresCidadesMaisQuentes;
        }

        public async Task<List<CidadeComEstadoClimaDto>> ObterTresCidadesMaisFrias()
        {
            var callDateTime = DateTime.Now;

            var tresCidadesMaisFrias = await Db.PrevisaoClimas
                .Where(p => DbFunctions.TruncateTime(p.DataPrevisao) == callDateTime.Date)
                .OrderBy(p => p.TemperaturaMinima)
                .Take(3)
                .Select(p => new CidadeComEstadoClimaDto
                {
                    CidadeId = p.CidadeId,
                    EstadoId = p.Cidade.EstadoId,
                    CidadeNome = p.Cidade.Nome,
                    UF = p.Cidade.Estado.UF,
                    Clima = p.Clima,
                    DataPrevisao = p.DataPrevisao,
                    TemperaturaMinima = p.TemperaturaMinima,
                    TemperaturaMaxima = p.TemperaturaMaxima
                })
                .ToListAsync();

            return tresCidadesMaisFrias;
        }
    }
}
