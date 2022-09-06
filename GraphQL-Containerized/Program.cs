using GraphQL;
using GraphQL_Containerized.Queries;
using GraphQL_Containerized.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<UserQuery>();
builder.Services.AddSingleton<UserType>();

builder.Services.AddGraphQL(b => b
    .AddAutoSchema<UserQuery>()  // schema
    .AddSystemTextJson());   // serializer

var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseWebSockets();
app.UseHttpsRedirection();
app.UseGraphQL("/graphql");            // url to host GraphQL endpoint
await app.RunAsync();
