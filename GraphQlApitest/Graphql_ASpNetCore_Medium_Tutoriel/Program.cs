using GraphQL.Types;
using Graphql_ASpNetCore_Medium_Tutoriel.ExtensionMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//injection des service lié a graphQl
builder.Services.AddgraphQl();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   
app.UseGraphQL<ISchema>("/graphql");//url pour l'host du endpoint graph ql
app.UseGraphQLPlayground(
    "/",// url pour host playground
    new GraphQL.Server.Ui.Playground.PlaygroundOptions 
    { 
        GraphQLEndPoint="/graphql",//url endpoint graphql
        SubscriptionsEndPoint="/graphql"//url endpoint graphql
    }
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
