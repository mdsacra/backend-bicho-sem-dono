using BichoSemDono.Application.Post.DTOs;
using BichoSemDono.Domain.Post.Entities;
using BichoSemDono.Domain.Post.Enums;
using BichoSemDono.Domain.Post.ValueObjects;

namespace BichoSemDono.Application.Post.QuerySide.ViewModels;

public struct OwnerlessPetPostViewModel
{
    public PetSpeciesEnum PetSpecies { get; init; }
    public string Description { get; init; }
    public LocalizationDto Localization { get; init; }

    public OwnerlessPetPostViewModel(OwnerlessPetPost ownerlessPetPost)
    {
        PetSpecies = ownerlessPetPost.PetSpecies;
        Description = ownerlessPetPost.Description;
        Localization = new LocalizationDto(
            latitude: ownerlessPetPost.Localization.Latitude, 
            longitude: ownerlessPetPost.Localization.Longitude
        );
    }
}