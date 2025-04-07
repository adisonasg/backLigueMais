using FaleMais.Data;
using FaleMais.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FaleMais.Domain.Handlers
{
    public static class CalcularTarifaSemPlano
    {
        public static async Task<double> Calcular(DataContext context, LigacaoModel tarifaModel)
        {
            Console.WriteLine($"Recebido para cálculo SEM PLANO: OrigemId = {tarifaModel.OrigemId}, DestinoId = {tarifaModel.DestinoId}, Minutagem = {tarifaModel.MinutagemLigacao}");

            var tarifa = await context.Tarifa
                .Include(x => x.Origem)
                .Include(x => x.Destino)
                .Where(x => x.OrigemId == tarifaModel.OrigemId && x.DestinoId == tarifaModel.DestinoId)
                .FirstOrDefaultAsync();

            if (tarifa == null)
            {
                Console.WriteLine("❌ Tarifa não encontrada para os IDs informados.");
                throw new Exception("Tarifa não encontrada para os DDDs informados.");
            }

            var valorSemPlano = tarifa.ValorTarifa * tarifaModel.MinutagemLigacao;
            Console.WriteLine($"✅ Valor SEM plano calculado: {valorSemPlano}");
            return valorSemPlano;
        }
    }
}
