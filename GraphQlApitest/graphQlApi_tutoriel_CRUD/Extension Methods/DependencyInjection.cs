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

            return services;
        }
    }
}
