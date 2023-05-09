using ApiTonic.API.Queries;
using ApiTonic.CoinMarketCap.ClientLibrary.Models;
using ApiTonic.CoinMarketCap.API.Models;
using StackExchange.Redis;
using ApiTonic.CoinMarketCap.API.Extensions;
using ApiTonic.CoinMarketCap.ClientLibrary.Extensions;

var builder = WebApplication.CreateBuilder(args);

var graphQLSettings = builder.Configuration.GetSection("ApiTonic:GraphQL").Get<GraphQLSettings>();

var services = builder.Services;

services.Configure<ApiSettings>(
    builder.Configuration.GetSection("ApiTonic:CoinMarketCapAPI"));
services.AddCors();

services
    .AddSingleton(ConnectionMultiplexer.Connect(graphQLSettings.RedisAddress))
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .InitializeOnStartup()
    .PublishSchemaDefinitionToRedis(graphQLSettings);

services.AddClientLibraryServices();

var app = builder.Build();

app.MapGraphQL();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .SetIsOriginAllowed(origin => true)
);

app.Run();
