using Microsoft.EntityFrameworkCore;
using Blazoropdracht;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Pet> Pets => Set<Pet>();
    public DbSet<Cage> Cages => Set<Cage>();
    public DbSet<Reservation> Reservations => Set<Reservation>();
    public DbSet<User> Users => Set<User>();   // ← nieuw

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cage>()
            .Property(c => c.Size)
            .HasConversion<string>();
    }
}