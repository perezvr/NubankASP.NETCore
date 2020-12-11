using NubankCore.Models;
using NubankCore.Repositories.Interfaces;

namespace Nubank_ASP.NET_Core.Repositories.Interfaces
{
    public interface IResponsavelRepository : IRespositoryBase<Responsavel>
    {
        public Responsavel GetByNome(string nome);
    }
}
