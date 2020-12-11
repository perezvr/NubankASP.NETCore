using Nubank_ASP.NET_Core.Repositories.Interfaces;
using NubankCore.Connection;
using NubankCore.Models;
using NubankCore.Repositories;
using System.Linq;

namespace Nubank_ASP.NET_Core.Repositories
{
    public class ResponsavelRepository : RepositoryBase<Responsavel>, IResponsavelRepository
    {
        public ResponsavelRepository(ApplicationContext applicationContext)
            : base(applicationContext)
        {

        }

        public Responsavel GetByNome(string nome) => DBSet.SingleOrDefault(r => r.Nome.Equals(nome));
    }
}
