using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NubankCore.Models
{
    public class Responsavel : ModelBase
    {
        private Responsavel() { }
       
        public Responsavel(string nome)
        {
            Nome = nome;
        }

        [Required]
        [MaxLength(30, ErrorMessage = "Nome deve ter no máximo 30 caracteres")]
        public string Nome { get; private set; }

        public List<Lancamento> Lancamentos { get; private set; }
    }
}
