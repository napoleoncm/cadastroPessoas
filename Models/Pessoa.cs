using System.ComponentModel.DataAnnotations;

namespace cadastroPessoas.Models
{
    public class Pessoa
    {

        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

    }
}
