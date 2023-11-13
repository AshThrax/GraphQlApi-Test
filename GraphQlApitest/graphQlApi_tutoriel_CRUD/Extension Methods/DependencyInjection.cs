using graphQlApi_tutoriel_CRUD.Contract;
using graphQlApi_tutoriel_CRUD.Entities.Context;
using graphQlApi_tutoriel_CRUD.Repository;
using Newtonsoft;
using Microsoft.EntityFrameworkCore;

namespace graphQlApi_tutoriel_CRUD.Extension_Methods
{
    /*
     * cette classe vas s'occuper de rassembler toutes les dependance a injecter dans le projet
     * 
     */
     
    public static class DependencyInjection
    {
        public static IServiceCollection AddgraphQl(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("SqlConString")));
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();

            services.AddControllers()
                .AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        

            return services;
        }
    }
}
