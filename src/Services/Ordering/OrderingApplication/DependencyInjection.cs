using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace OrderingApplication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddMediatR(cfg =>
            //{
            //    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            //});



            return services;
        }
    }
}
