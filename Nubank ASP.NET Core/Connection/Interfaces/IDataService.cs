using System;

namespace NubankCore.Connection.Interfaces
{
    public interface IDataService
    {
        public void InitializeDB(IServiceProvider serviceProvider);
    }
}
