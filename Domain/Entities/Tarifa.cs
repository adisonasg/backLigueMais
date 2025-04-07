using System.ComponentModel.DataAnnotations;

namespace FaleMais.Entities
{
    public class Tarifa
    {
        public Tarifa() { } 

        public Tarifa(int id, double valorTarifa, int origemId, int destinoId)
        {
            Id = id;
            ValorTarifa = valorTarifa;
            OrigemId = origemId;
            DestinoId = destinoId;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório")]
        public double ValorTarifa { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório")]
        public int OrigemId { get; set; }
        public DDD Origem { get; set; }
        
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public int DestinoId { get; set; }
        public DDD Destino { get; set; }


    }
}
