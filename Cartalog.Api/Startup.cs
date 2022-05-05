using Cartalog.Data.Core;
using Cartalog.Utilities.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Cartalog.Api
{
    public class Startup
    {
        private readonly IConfigurationRoot configuration;

        public Startup(IWebHostEnvironment environment)
        {
            configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddUserSecrets<Startup>()
                .Build();
        }

        public void Configure(IApplicationBuilder app)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = configuration["ConnectionStrings:CartalogDatabase"];

            if (connectionString.IsNullOrWhiteSpace())
                throw new InvalidOperationException("No connectionstring could be found");

            services.AddDbContext<CartalogDbContext>(options => options.UseNpgsql(connectionString));
        }
    }
}