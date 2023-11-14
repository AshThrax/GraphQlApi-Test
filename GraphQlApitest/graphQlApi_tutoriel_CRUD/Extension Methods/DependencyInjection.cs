using graphQlApi_tutoriel_CRUD.Contract;
using graphQlApi_tutoriel_CRUD.Entities.Context;
using graphQlApi_tutoriel_CRUD.Repository;
using Microsoft.EntityFrameworkCore;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using graphQlApi_tutoriel_CRUD.GraphQl.GraphQLSchema;

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

            services.AddScoped<AppSchema>();

            services.AddGraphQL()
                .AddSystemTextJson()
                .AddGraphTypes(typeof(AppSchema),ServiceLifetime.Scoped);

            services.AddControllers().AddNewtonsoftJson(opt =>opt.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        

            return services;
        }
    }
}
