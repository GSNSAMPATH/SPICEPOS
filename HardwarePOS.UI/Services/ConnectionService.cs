using HardwarePOS.Data.Database;
using Microsoft.Extensions.Configuration;

namespace HardwarePOS.UI.Services
{
    public static class ConnectionService
    {
        public static DbConnectionFactory CreateFactory()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString =
                configuration.GetConnectionString("DefaultConnection");

            return new DbConnectionFactory(connectionString);
        }
    }
}