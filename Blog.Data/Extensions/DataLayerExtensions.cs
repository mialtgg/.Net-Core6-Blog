using Blog.dATA.Context;
using Blog.dATA.Repositories.Abstractions;
using Blog.dATA.Repositories.Concretes;
using Blog.dATA.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.dATA.Extentions
{
   public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDatLayerExtention(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IunitOfWork, UnitOfWork>();

            return services;
        }
    }
}
