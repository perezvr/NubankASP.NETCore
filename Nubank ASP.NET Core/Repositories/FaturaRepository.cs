using Microsoft.AspNetCore.Http;
using Nubank_ASP.NET_Core.Util;
using NubankCore.Connection;
using NubankCore.Models;
using NubankCore.Repositories.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NubankCore.Repositories
{
    public class FaturaRepository : RepositoryBase<Fatura>, IFaturaRepository
    {
        public FaturaRepository(ApplicationContext applicationContext)
            : base(applicationContext)
        {
        }

        /// <summary>
        /// Gera uma fatura a partir de um arquivo .csv válido
        /// </summary>
        /// <param name="Caminho">Caminho do arquivo .csv</param>
        public async Task<Fatura> GerarFatura(IFormFile file, DateTime dtInicial, DateTime dtFinal)
        {
            try
            {
                var stream = await ReadAsStringAsync(file);
                var lines = stream.Split(Environment.NewLine).Skip(1).ToList();
                lines.RemoveAt(lines.Count - 1);

                Fatura fatura = new Fatura(dtInicial, dtFinal);
                Lancamento lancamento;

                foreach (string line in lines)
                {
                    var values = line.Split(',');

                    var data = DateTime.Parse(values[0]);
                    var categoria = values[1];
                    var descricao = NubankToolBox.DefineDescricao(values[2]);
                    //int parcela = NubankToolBox.DefineParcela(descricao);
                    //int numParcelas = NubankToolBox.DefineNumParcelas(descricao);
                    var valor = NubankToolBox.FormataValor(values[3]);

                    lancamento = new Lancamento(data, categoria, descricao, 0, 0, valor, fatura, new Responsavel("Casa"));

                    fatura.Lancamentos.Add(lancamento);
                }

                return fatura;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<string> ReadAsStringAsync(IFormFile file)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(await reader.ReadLineAsync());
            }
            return result.ToString();
        }

    }
}
