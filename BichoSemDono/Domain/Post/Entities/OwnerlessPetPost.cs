using BichoSemDono.Domain.Post.Enums;
using BichoSemDono.Domain.Post.ValueObjects;

namespace BichoSemDono.Domain.Post.Entities;

public class OwnerlessPetPost : BasePost
{
    public PetSpeciesEnum PetSpecies { get; }
    
    public OwnerlessPetPost(
        PetSpeciesEnum petSpecies,
        string description,
        Localization localization) : base(description, localization)
    {
        PetSpecies = petSpecies;
    }

    public OwnerlessPetPost() { }
}