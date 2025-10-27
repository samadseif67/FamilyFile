using FamilyFile.Domain.Interfaces;
using FamilyFile.Infrastructure.Data;
using FamilyFile.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Infrastructure
{
    public static class DependencyInjectionInfrastructure
    {
        public static IServiceCollection DependencyInjectionInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFamilyMemberRepository,FamilyMemberRepository>();
            services.AddScoped<IPersonnelRepository, PersonnelRepository>();
            services.AddDbContext<FamilyFileContext>(x => x.UseSqlServer(configuration.GetConnectionString("FamilyFileConnectionStrings")));
            return services;
        }
    }
}
