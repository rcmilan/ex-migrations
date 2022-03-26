using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using Persistence.Configurations;

namespace Persistence
{
    public static class ModuleDependency
    {
        public static void AddDatabaseModule(this IServiceCollection services, string connectionString)
        {
            var mySqlConnection = new MySqlConnection(connectionString);

            services.AddDbContext<PersistenceDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(mySqlConnection)));
        }
    }
}