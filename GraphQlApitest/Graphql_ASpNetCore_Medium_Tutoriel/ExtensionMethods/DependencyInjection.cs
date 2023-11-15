using GraphQL;
using GraphQL.Types;
using Graphql_ASpNetCore_Medium_Tutoriel.GraphQl;
using Graphql_ASpNetCore_Medium_Tutoriel.Model;
using Graphql_ASpNetCore_Medium_Tutoriel.Service;

namespace Graphql_ASpNetCore_Medium_Tutoriel.ExtensionMethods
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddgraphQl
            (this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<EmployeeDetailsType>();
            services.AddScoped<EmployeeQuery>();
            services.AddScoped<ISchema, EmployeeDetailsSchema>();
            services.AddGraphQL(x => x.AddAutoSchema<EmployeeQuery>()//schema 
                                            .AddSystemTextJson());//serializer
            return services;
        }
    }
}
