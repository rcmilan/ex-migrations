using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using Persistence.Configurations;
using Persistence.Repositories;

namespace Persistence
{
    public static class ModuleDependency
    {
        public static void AddDatabaseModule(this IServiceCollection services, string connectionString)
        {
            var mySqlConnection = new MySqlConnection(connectionString);

            services.AddDbContext<PersistenceDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(mySqlConnection)));

            services.AddScoped<IRepository<Accommodation, long>, GenericRepository<Accommodation, long>>();
            services.AddScoped<IRepository<City, Guid>, GenericRepository<City, Guid>>();
            services.AddScoped<IRepository<School, long>, GenericRepository<School, long>>();
        }
    }
}