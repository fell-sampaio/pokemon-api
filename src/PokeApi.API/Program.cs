using Microsoft.EntityFrameworkCore;
using PokeApi.Application.Interfaces;
using PokeApi.Domain.Interfaces;
using PokeApi.Infrastructure.Data;
using PokeApi.Infrastructure.Repositories;
using PokeApi.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IPokemonApiService, PokemonApiService>(client =>
{
    var baseUrl = builder.Configuration["PokemonApi:BaseUrl"];
    client.BaseAddress = new Uri(baseUrl);
});
builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.Run();
