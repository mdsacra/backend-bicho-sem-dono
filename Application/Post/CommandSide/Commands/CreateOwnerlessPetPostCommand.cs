using BichoSemDono.Application.Post.DTOs;
using BichoSemDono.Domain.Post.Enums;
using MediatR;

namespace BichoSemDono.Application.Post.CommandSide.Commands;

public struct CreateOwnerlessPetPostCommand : IRequest<Guid>
{
    public string? Description { get; init; }
    public PetSpeciesEnum PetSpecies { get; init; }
    public LocalizationDto Localization { get; init; }

    public CreateOwnerlessPetPostCommand(string? description, PetSpeciesEnum petSpecies, LocalizationDto localization)
    {
        Description = description;
        PetSpecies = petSpecies;
        Localization = localization;
    }
}