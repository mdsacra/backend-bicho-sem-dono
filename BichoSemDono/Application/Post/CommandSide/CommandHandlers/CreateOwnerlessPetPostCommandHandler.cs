using BichoSemDono.Application.Post.CommandSide.Commands;
using BichoSemDono.Core.Infrastructure;
using BichoSemDono.Domain.Post.Entities;
using BichoSemDono.Domain.Post.ValueObjects;
using MediatR;

namespace BichoSemDono.Application.Post.CommandSide.CommandHandlers;

public class CreateOwnerlessPetPostCommandHandler : IRequestHandler<CreateOwnerlessPetPostCommand, Guid>
{
    private readonly BichoSemDonoContext _context;

    public CreateOwnerlessPetPostCommandHandler(BichoSemDonoContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreateOwnerlessPetPostCommand command, CancellationToken cancellationToken)
    {
        var ownerlessPetPost = new OwnerlessPetPost(
            petSpecies: command.PetSpecies,
            description: command.Description ?? string.Empty,
            localization: new Localization(
                latitude: command.Localization.Latitude,
                longitude: command.Localization.Longitude
            )
        );

        await _context.OwnerlessPetPosts.AddAsync(ownerlessPetPost, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return ownerlessPetPost.Id;
    }
}