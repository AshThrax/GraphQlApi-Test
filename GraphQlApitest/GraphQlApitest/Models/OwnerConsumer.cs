using GraphQL;
using GraphQL.Client.Abstractions;

namespace GraphQlApitest.Models
{
    //CETTE CLASSE SERVIRA A STOCKER LES QUERIES ET LES MUTATIONS
    public class OwnerConsumer
    {
        private readonly IGraphQLClient _client;

        public OwnerConsumer(IGraphQLClient client)
        {
            _client = client;
        }
        //creation d'une requete grapgql renvoyant tout mles objet de type Owner 
        public async Task<List<Owner>> GetAllOwner ()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                query ownersQuery{

                    owners{
                      id
                      name 
                      address 
                      account{
                               id 
                               type 
                               description 
                             }    
                           }    
                        }"
            };
            //attente de la reposne 
            var response = await _client.SendQueryAsync<ResponseOwnerCollectionType>(query);
            return response.Data.Owners;
        }
    }
}
