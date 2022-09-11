using BichoSemDono.Application.Post.QuerySide.Queries;
using BichoSemDono.Application.Post.QuerySide.ViewModels;
using BichoSemDono.Core.Infrastructure;
using MediatR;

namespace BichoSemDono.Application.Post.QuerySide.QueryHandlers;

public class ListOwnerlessPetPostsQueryHandler : IRequestHandler<ListOwnerlessPetPostsQuery, IEnumerable<OwnerlessPetPostViewModel>>
{
    private readonly BichoSemDonoContext _context;

    public ListOwnerlessPetPostsQueryHandler(BichoSemDonoContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<OwnerlessPetPostViewModel>> Handle(
        ListOwnerlessPetPostsQuery request,
        CancellationToken cancellationToken)
        => _context.OwnerlessPetPosts.Select(opp => new OwnerlessPetPostViewModel(opp));
}