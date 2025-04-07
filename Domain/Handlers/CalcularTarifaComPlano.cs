using FaleMais.Data;
using FaleMais.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FaleMais.Domain.Handlers
{
    public static class CalcularTarifaComPlano
    {
        public static async Task<double> Calcular(DataContext context, LigacaoModel tarifaModel)
        {
            var plano = await context.Plano.Where(x => x.Id == tarifaModel.PlanoId)
                .FirstOrDefaultAsync();

            var tarifa = await context.Tarifa.Include(x => x.Origem)
                .Include(x => x.Destino)
                .Where(x => x.OrigemId == tarifaModel.OrigemId && x.DestinoId == tarifaModel.DestinoId)
                .FirstOrDefaultAsync();

            var minutagemAPagar = tarifaModel.MinutagemLigacao - plano.Minutagem;


            double tarifaComPlano = minutagemAPagar * tarifa.ValorTarifa * 1.1;

            return minutagemAPagar > 0 ? tarifaComPlano : 0;
        }
    }
}
