
using onion.Domain.Interfaces.Repositories;

namespace onion.API.extensions
{
    public static class DependencyInjectionExtension
    {
        public static void ResolveCustomDependences(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, Infrastructure.Dapper.Repositories.PersonRepository>();
            services.AddScoped<IPersonRepository, Infrastructure.EFCore.Repositories.PersonRepository>();
        }
    }
}