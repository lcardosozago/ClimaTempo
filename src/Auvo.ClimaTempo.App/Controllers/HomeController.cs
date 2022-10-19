using Auvo.ClimaTempo.Business.Models.Cidades;
using Auvo.ClimaTempo.Business.Models.PrevisaoClimas;
using Auvo.ClimaTempo.Infra.Data.Repository;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Auvo.ClimaTempo.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICidadeRepository _cidadeRepository = new CidadeRepository();
        private readonly IPrevisaoClimaRepository _previsaoClimaRepository = new PrevisaoClimaRepository();

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> Index()
        {
            var previsaoClimaTresCidadesMaisQuentes = await _previsaoClimaRepository.ObterTresCidadesMaisQuentes();
            var previsaoClimaTresCidadesMaisFrias = await _previsaoClimaRepository.ObterTresCidadesMaisFrias();

            var cidades = await _cidadeRepository.ObterCidadesComEstados();

            ViewBag.PrevisaoClimaCidadesMaisQuentes = previsaoClimaTresCidadesMaisQuentes;
            ViewBag.PrevisaoClimaCidadesMaisFrias = previsaoClimaTresCidadesMaisFrias;
            ViewBag.Cidades = cidades;

            return View();
        }

        [HttpGet]
        [Route("sobre")]
        public ActionResult About()
        {
            return View();
        }
    }
}