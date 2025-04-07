using FaleMais.Entities;
using System.ComponentModel.DataAnnotations;

namespace FaleMais.Models
{
    public class LigacaoModel
    {
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int PlanoId { get; set;}
        public Plano Plano { get; set;}
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int OrigemId { get; set; }
        public DDD Origem { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int DestinoId { get; set; }
        public DDD Destino { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int MinutagemLigacao { get; set; }
    }
}
