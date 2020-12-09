using Microsoft.AspNetCore.Http;
using NubankCore.Models;
using System;
using System.Threading.Tasks;

namespace NubankCore.Repositories.Interfaces
{
    public interface IFaturaRepository : IRespositoryBase<Fatura>
    {
        public Task<Fatura> GerarFatura(IFormFile file, DateTime dtInicial, DateTime dtFinal);
    }
}
