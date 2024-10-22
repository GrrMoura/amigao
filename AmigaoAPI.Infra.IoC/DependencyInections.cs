using AmigaoAPI.Application.Services.Interface;
using AmigaoAPI.Application.Services;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Infra.Data.Context;
using AmigaoAPI.Infra.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Amigao.Api.Application.Mapeamento;

namespace AmigaoAPI.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuração do DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Configuração dos Repositórios


            services.AddScoped<IReservaRepositorio, ReservaRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IChurrasqueiroRepositorio, ChurrasqueiroRepositorio>();
            services.AddScoped<IAvaliacaoChurrasqueiroRepositorio, AvaliacaoChurrasqueiroRepositorio>();
            return services;
        }


        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuração do AutoMapper
            services.AddAutoMapper(typeof(DomainToDtoMapping)); // Colocando as funcionalidades do AutoMapper

            // Registro dos Serviços
            services.AddScoped<IReservaService, ReservaService>();
            services.AddScoped<IChurrasqueiroService, ChurrasqueiroService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            



            return services;

        }
    }
}
