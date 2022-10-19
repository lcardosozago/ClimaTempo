using Auvo.ClimaTempo.Business.Models.PrevisaoClimas;
using Auvo.ClimaTempo.Infra.Data.Repository;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Auvo.ClimaTempo.App.Controllers
{
    [RoutePrefix("clima")]
    public class ClimaController : Controller
    {
        private readonly IPrevisaoClimaRepository _previsaoClimaRepository = new PrevisaoClimaRepository();

        [HttpGet]
        [Route("sete-dias-previsao/{cidadeId:int}")]
        public async Task<ActionResult> ObterSeteDiasDePrevisaoPorCidadeId(int cidadeId)
        {
            var previsaoSeteProximosDias = await _previsaoClimaRepository.ObterPrevisaoClimaDosProximosSeteDiasPorCidadeId(cidadeId);

            return Json(new
            {
                lista = previsaoSeteProximosDias
            }, JsonRequestBehavior.AllowGet);
        }
    }
}