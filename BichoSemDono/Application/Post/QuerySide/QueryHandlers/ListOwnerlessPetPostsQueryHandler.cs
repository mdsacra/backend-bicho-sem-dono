using BichoSemDono.Application.Post.QuerySide.Queries;
using BichoSemDono.Application.Post.QuerySide.ViewModels;
using BichoSemDono.Core.Infrastructure.ContextConfiguration;
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
    {
        var longitude = request.Longitude;
        var latitude = request.Latitude;
        var eastLimitLongitude = longitude + 0.2;
        var westLimitLongitude = longitude - 0.2;
        var northLimitLatitude = latitude + 0.2;
        var southLimitLatitude = latitude - 0.2;

        return _context.OwnerlessPetPosts
            .Where(opp =>
                (opp.Localization.Longitude <= eastLimitLongitude && opp.Localization.Longitude >= westLimitLongitude) &&
                (opp.Localization.Latitude <= northLimitLatitude && opp.Localization.Latitude >= southLimitLatitude))
            .Select(opp => new OwnerlessPetPostViewModel(opp));
    }
}