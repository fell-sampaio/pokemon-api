using PokeApi.Domain.Interfaces;
using PokeApi.Infrastructure.Data;

namespace PokeApi.Infrastructure.Repositories;
public class PokemonRepository(AppDbContext context) : IPokemonRepository
{
    private readonly AppDbContext _context = context;
}
