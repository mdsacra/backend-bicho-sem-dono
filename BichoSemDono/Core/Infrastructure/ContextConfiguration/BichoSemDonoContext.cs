using System.Reflection;
using BichoSemDono.Domain.Post.Entities;
using BichoSemDono.Domain.User.Entities;
using Microsoft.EntityFrameworkCore;

namespace BichoSemDono.Core.Infrastructure.ContextConfiguration;

public class BichoSemDonoContext : DbContext
{
    public BichoSemDonoContext(DbContextOptions<BichoSemDonoContext> options) : base(options) { }

    public DbSet<OwnerlessPetPost> OwnerlessPetPosts => Set<OwnerlessPetPost>();
    public DbSet<BaseUser> Users => Set<BaseUser>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}