using FaleMais.Data;
using FaleMais.Domain.Handlers;
using FaleMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FaleMais.Controllers
{
    [Route("tarifa")]
    [ApiController]
    public class TarifaController : ControllerBase
    {
        [HttpPost]
        [Route("calcular-tarifa")]
        public async Task<ActionResult<CalcularTarifaModel>> CalcularTarifa(
            [FromServices] DataContext context,
            [FromBody] LigacaoModel tarifaModel)
        {
            var tarifaSemPlano = await CalcularTarifaSemPlano.Calcular(context, tarifaModel);
            var tarifaComPlano = await CalcularTarifaComPlano.Calcular(context, tarifaModel);

            return Ok(new CalcularTarifaModel() { ValorComPlano = tarifaComPlano, ValorSemPlano = tarifaSemPlano });
        }

    }
}
