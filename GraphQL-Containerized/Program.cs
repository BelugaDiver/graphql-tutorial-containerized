using GraphQL;
using GraphQL.Types;
using GraphQL_Containerized.GraphQl.Schemas;
using GraphQL_Containerized.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<UserQuery>();
builder.Services.AddSingleton<ISchema>(new UserSchema());
//builder.Services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
builder.Services.AddGraphQL(b => b
        .AddAutoSchema<ISchema>()  // schema
        .AddSystemTextJson()
    )
    .AddLogging(c => c.AddConsole());   // serializer

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseDeveloperExceptionPage();
app.UseWebSockets();
app.UseHttpsRedirection();
app.UseGraphQL("/graphql");            // url to host GraphQL endpoint
app.UseGraphQLPlayground(
    "/",                               // url to host Playground at
    new GraphQL.Server.Ui.Playground.PlaygroundOptions
    {
        GraphQLEndPoint = "/graphql",         // url of GraphQL endpoint
        SubscriptionsEndPoint = "/graphql",   // url of GraphQL endpoint
    });


await app.RunAsync();