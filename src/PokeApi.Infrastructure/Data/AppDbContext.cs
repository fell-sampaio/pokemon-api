using Microsoft.EntityFrameworkCore;
using PokeApi.Domain.Entities;

namespace PokeApi.Infrastructure.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Pokemon> Pokemons { get; set; }
}
