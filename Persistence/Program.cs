using Microsoft.Extensions.Hosting;
using Persistence;

string connString = "server=localhost;port=3306;userid=mysqlusr;password=password;database=accommodations;";

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => services.AddDatabaseModule(connString))
    .Build();

await host.RunAsync();