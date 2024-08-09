using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OrderingInfrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection service, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Database");

            //service.AddDbContext<ApplicationContext>(options =>
            //{
            //    options.UseSqlServer(connectionString);
            //});

            return service;
        }
    }
}
