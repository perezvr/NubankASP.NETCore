using System;
using System.ComponentModel.DataAnnotations;

namespace NubankCore.Models
{
    public class Lancamento : ModelBase
    {
        private Lancamento() { }
        public Lancamento(DateTime data, string categoria, string descricao, int parcela, int numParcelas, decimal valor, Fatura fatura, Responsavel responsavel)
        {
            Data = data;
            Categoria = categoria;
            Descricao = descricao;
            Parcela = parcela;
            NumParcelas = numParcelas;
            Valor = valor;
            Fatura = fatura;
            Responsavel = responsavel;
        }

        [Required]
        public DateTime Data { get; private set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Categoria deve ter no máximo 30 caracteres")]
        public string Categoria { get; private set; }

        [Required]
        [MaxLength(80, ErrorMessage = "Descrição deve ter no máximo 80 caracteres")]
        public string Descricao { get; private set; }

        [Required]
        public int Parcela { get; private set; }

        [Required]
        public int NumParcelas { get; private set; }

        [Required]
        [Range(0, 999999.99)]
        public decimal Valor { get; private set; }

        [Required]
        public Fatura Fatura { get; private set; }

        [Required]
        public Responsavel Responsavel { get; private set; }
    }
}
