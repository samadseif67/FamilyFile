using FamilyFile.Application.Services.FamilyMemberUseCase;
using FamilyFile.Application.Services.PersonnelUseCase;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application
{
    public static class DependencyInjectionApplication
    {
        public static IServiceCollection DependencyInjectionApplicationDI(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DependencyInjectionApplication).Assembly);
            services.AddScoped<IFamilyMemberService, FamilyMemberService>();
            services.AddScoped<IPersonnelService,PersonnelService>();
            return services;
        }
    }
}
