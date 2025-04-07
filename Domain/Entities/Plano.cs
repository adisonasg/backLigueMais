using System.ComponentModel.DataAnnotations;

namespace FaleMais.Entities
{
    public class Plano
    {

        public Plano() { }

        public Plano(int id, string name, double minutagem)
        {
            Id = id;
            Name = name;
            Minutagem = minutagem;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double Minutagem { get; set; }


    }
}
