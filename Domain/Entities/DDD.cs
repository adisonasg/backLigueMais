using System.ComponentModel.DataAnnotations;

namespace FaleMais.Entities
{
    public class DDD
    {
        public DDD() { }

        public DDD(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Descricao { get; set; }
    }
}
