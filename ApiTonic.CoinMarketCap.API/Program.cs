using ApiTonic.API.Queries;
using ApiTonic.CoinMarketCap.ClientLibrary.Models;
using ApiTonic.CoinMarketCap.ClientLibrary;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ApiSettings>(
    builder.Configuration.GetSection("ApiSettings"));

builder.Services.AddMvc();
builder.Services.AddGraphQLServer();
builder.Services.AddCors();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

builder.Services.AddClientLibraryServices();

var app = builder.Build();

app.MapControllers();
app.MapGraphQL();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .SetIsOriginAllowed(origin => true)
);

app.Run();
