using BichoSemDono.Application.Post.QuerySide.ViewModels;
using MediatR;

namespace BichoSemDono.Application.Post.QuerySide.Queries;

public struct ListOwnerlessPetPostsQuery : IRequest<IEnumerable<OwnerlessPetPostViewModel>>
{
    public string Longitude { get; init; }
    public string Latitude { get; init; }

    public ListOwnerlessPetPostsQuery(string longitude, string latitude)
    {
        Longitude = longitude;
        Latitude = latitude;
    }
}