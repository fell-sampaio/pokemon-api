using Microsoft.Extensions.Configuration;
using PokeApi.Application.Interfaces;

namespace PokeApi.Infrastructure.Services;
public class PokemonApiService(HttpClient httpClient, IConfiguration configuration) : IPokemonApiService
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly string _baseUrl = configuration["PokemonApi:BaseUrl"];
}
