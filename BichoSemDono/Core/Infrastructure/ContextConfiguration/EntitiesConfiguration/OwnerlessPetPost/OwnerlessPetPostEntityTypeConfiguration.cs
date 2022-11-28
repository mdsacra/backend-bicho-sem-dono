using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BichoSemDono.Core.Infrastructure.ContextConfiguration.EntitiesConfiguration.OwnerlessPetPost;

public class OwnerlessPetPostEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Post.Entities.OwnerlessPetPost>
{
    public void Configure(EntityTypeBuilder<Domain.Post.Entities.OwnerlessPetPost> builder)
    {
        builder.HasKey(opp => opp.Id);
            
        builder
            .Property(opp => opp.Id)
            .ValueGeneratedNever();

        builder
            .Property(opp => opp.Description)
            .IsRequired();
        
        builder
            .Property(opp => opp.CreatedAt)
            .ValueGeneratedNever();

        builder.OwnsOne(opp => opp.Localization);

        builder
            .Property(opp => opp.PetSpecies)
            .IsRequired();
    }
}