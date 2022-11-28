using BichoSemDono.Domain.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BichoSemDono.Core.Infrastructure.ContextConfiguration.EntitiesConfiguration.User;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<BaseUser>
{
    public void Configure(EntityTypeBuilder<BaseUser> builder)
    {
        builder.HasKey(u => u.Id);
        
        builder
            .Property(u => u.Id)
            .ValueGeneratedNever();
        
        builder
            .Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(200);
        
        builder
            .Property(u => u.PetsQuantity)
            .IsRequired();
        
        builder
            .Property(u => u.Password)
            .IsRequired();
        
        builder
            .Property(u => u.Profile)
            .IsRequired();

        builder.Property(e => e.Email)
            .HasMaxLength(200);

        builder.Property(e => e.Phone)
            .HasMaxLength(13);

        builder
            .Property(u => u.CreatedAt)
            .ValueGeneratedNever();
    }
}