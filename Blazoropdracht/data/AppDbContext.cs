using Microsoft.EntityFrameworkCore;
using Blazoropdracht;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Pet> Pets => Set<Pet>();
}