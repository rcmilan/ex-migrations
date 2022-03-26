using Microsoft.Extensions.Hosting;
using Persistence;

Console.WriteLine("ConnectionString:");
string connString = Console.ReadLine();

if (string.IsNullOrEmpty(connString)) throw new Exception("Connection String Vazia!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) => services.AddDatabaseModule(connString))
    .Build();

await host.RunAsync();