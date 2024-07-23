using PokeApi.Application.Interfaces;
using PokeApi.Domain.Interfaces;

namespace PokeApi.Application.Services;
public class PokemonService(IPokemonApiService pokemonApiService, IPokemonRepository pokemonRepository) : IPokemonService
{
    private readonly IPokemonApiService _pokemonApiService = pokemonApiService;
    private readonly IPokemonRepository _pokemonRepository = pokemonRepository;
}
