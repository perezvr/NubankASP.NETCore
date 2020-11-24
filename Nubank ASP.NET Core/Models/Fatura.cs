using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NubankCore.Models
{
    public class Fatura: ModelBase
    {
        private Fatura() { }
       
        public Fatura(DateTime abertura, DateTime fechamento)
        {
            Abertura = abertura;
            Fechamento = fechamento;
        }

        [Required]
        public DateTime Abertura{ get; private set; }
        [Required]
        public DateTime Fechamento { get; private set; }

        public List<Lancamento> Lancamentos { get; private set; }
    }
}
