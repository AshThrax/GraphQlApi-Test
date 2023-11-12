using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQlApitest.Models;

namespace GraphQlApitest.ExtensionMethods
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddgraphQl(this IServiceCollection services, IConfiguration configuration)
        {
            //enregistrement du service relatif a graphqlS
            services.AddScoped<IGraphQLClient>(s => new GraphQLHttpClient(configuration["GraphQLURI"], new NewtonsoftJsonSerializer()));

            services.AddScoped<OwnerConsumer>();
            return services;
        }
    }
}
