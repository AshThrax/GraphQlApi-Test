using GraphQL.Types;
using graphQlApi_tutoriel_CRUD.GraphQl.GraphQLQueries;

namespace graphQlApi_tutoriel_CRUD.GraphQl.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider):base (provider) {
            Query = provider.GetRequiredService<AppQuerry>();
        }
        

        
    }
}
