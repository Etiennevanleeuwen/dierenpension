using Microsoft.EntityFrameworkCore;
using Blazoropdracht;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Pet> Pets => Set<Pet>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>().HasData(
            new Client { Id = 1, Name = "Acme BV", Address = "Hoofdstraat 1", Zipcode = "1234 AB", City = "Amsterdam" },
            new Client { Id = 2, Name = "Widgets NV", Address = "Keizersgracht 42", Zipcode = "5678 CD", City = "Rotterdam" },
            new Client { Id = 3, Name = "Gadgets BV", Address = "Markt 7", Zipcode = "9012 EF", City = "Utrecht" }
        );

        modelBuilder.Entity<Pet>().HasData(
            new Pet { Id = 1, Name = "Rex", ClientId = 1 },
            new Pet { Id = 2, Name = "Whiskers", ClientId = 2 }
        );
    }
}