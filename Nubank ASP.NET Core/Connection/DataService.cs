using Microsoft.EntityFrameworkCore;
//Necessário incluir na mão
using Microsoft.Extensions.DependencyInjection;
using NubankCore.Connection.Interfaces;
using System;

namespace NubankCore.Connection
{
    public class DataService : IDataService
    {
        public void InitializeDB(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationContext>();
            context.Database.Migrate();
        }
    }
}
