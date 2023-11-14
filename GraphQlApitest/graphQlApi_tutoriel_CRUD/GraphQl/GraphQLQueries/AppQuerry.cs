using GraphQL.Types;
using graphQlApi_tutoriel_CRUD.Contract;
using graphQlApi_tutoriel_CRUD.GraphQl.GraphQlType;

namespace graphQlApi_tutoriel_CRUD.GraphQl.GraphQLQueries
{
    public class AppQuerry : ObjectGraphType
    {
        public AppQuerry(IOwnerRepository Repository)
        {
            Field<ListGraphType<Ownertype>>("owner",

                resolve: context =>Repository.GetAll()
                );
        }
    }
}
