using BichoSemDono.Domain.Post.Entities;
using Microsoft.EntityFrameworkCore;

namespace BichoSemDono.Core.Infrastructure;

public class BichoSemDonoContext : DbContext
{
    public BichoSemDonoContext(DbContextOptions<BichoSemDonoContext> options) : base(options) { }

    public DbSet<OwnerlessPetPost> OwnerlessPetPosts => Set<OwnerlessPetPost>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureOwnerlessPetPostEntity(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    private void ConfigureOwnerlessPetPostEntity(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OwnerlessPetPost>()
            .HasKey(opp => opp.Id);
            
        modelBuilder.Entity<OwnerlessPetPost>()
            .Property(opp => opp.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<OwnerlessPetPost>()
            .Property(opp => opp.Description)
            .IsRequired();
        
        modelBuilder.Entity<OwnerlessPetPost>()
            .Property(opp => opp.CreatedAt)
            .ValueGeneratedNever();

        modelBuilder.Entity<OwnerlessPetPost>()
            .OwnsOne(opp => opp.Localization);

        modelBuilder.Entity<OwnerlessPetPost>()
            .Property(opp => opp.PetSpecies)
            .IsRequired();
    }
}