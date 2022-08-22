using BichoSemDono.Domain.Post.Enums;
using BichoSemDono.Domain.Post.ValueObjects;
using BichoSemDono.Domain.User.Entities;

namespace BichoSemDono.Domain.Post.Entities;

public class OwnerlessPetPost : BasePost
{
    public PetSpeciesEnum PetSpecies { get; }
    
    public OwnerlessPetPost(
        PetSpeciesEnum petSpecies,
        string description,
        Localization localization,
        BaseUser? publisher) : base(description, localization, publisher)
    {
        PetSpecies = petSpecies;
    }
}