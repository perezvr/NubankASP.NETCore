using NubankCore.Connection;
using NubankCore.Models;
using NubankCore.Repositories.Interfaces;

namespace NubankCore.Repositories
{
    public class FaturaRepository : RepositoryBase<Fatura>, IFaturaRepository
    {
        public FaturaRepository(ApplicationContext applicationContext) 
            : base(applicationContext)
        {
        }
    }
}
