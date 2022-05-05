using Cartalog.Api;

var builder = WebApplication.CreateBuilder();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
    .Build();

host.Run();