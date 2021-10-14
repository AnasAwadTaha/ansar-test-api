using ansar_group_task.Data.Model;
using ansar_group_task.Data.Repositores;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ansar_group_task.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<RegisterRepository>();
        }
    }
}
