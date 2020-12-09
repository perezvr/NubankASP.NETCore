using System;

namespace Nubank_ASP.NET_Core.Util
{
    public class NubankToolBox
    {
        public static decimal FormataValor(string valor) => decimal.Parse(valor.Replace('.', ','));

        public static int DefineParcela(string descricao)
        {
            try
            {
                int.TryParse(descricao.Substring(descricao.LastIndexOf(' '), descricao.LastIndexOf('/') - descricao.LastIndexOf(' ')), out int parcela);
                return parcela;
            }
            catch
            { return 0; }
        }

        public static int DefineNumParcelas(string descricao)
        {
            try
            {
                int.TryParse(descricao.Substring(descricao.LastIndexOf('/') + 1), out int numParcelas);
                return numParcelas;
            }
            catch (Exception)
            { return 0; }

        }

        public static string DefineDescricao(string descricao)
        {
            try
            {
                return !descricao.IndexOf('/').Equals(-1)
                    ? descricao.Substring(0, descricao.LastIndexOf(' '))
                    : descricao;
            }
            catch (IndexOutOfRangeException)
            {
                return descricao;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
