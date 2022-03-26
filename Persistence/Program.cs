using Microsoft.Extensions.Hosting;
using Persistence;

string connString = "server=localhost;port=3306;userid=mysqlusr;password=password;database=accommodations;";
Console.WriteLine("ConnectionString: {0}", connString);

if (string.IsNullOrEmpty(connString)) throw new Exception("Connection String Vazia!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => services.AddDatabaseModule(connString))
    .Build();

await host.RunAsync();