using graphQlApi_tutoriel_CRUD.Extension_Methods;
using graphQlApi_tutoriel_CRUD.GraphQl.GraphQLSchema;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var config = builder.Configuration;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddgraphQl(config);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseGraphQL<AppSchema>();

app.UseEndpoints(endpoints => endpoints.MapControllers() );
app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());

app.Run();
