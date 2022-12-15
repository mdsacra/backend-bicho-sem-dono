using BichoSemDono.Application.Post.QuerySide.ViewModels;
using MediatR;

namespace BichoSemDono.Application.Post.QuerySide.Queries;

public struct ListOwnerlessPetPostsQuery : IRequest<IEnumerable<OwnerlessPetPostViewModel>>
{
    public double Longitude { get; init; }
    public double Latitude { get; init; }

    public ListOwnerlessPetPostsQuery(double longitude, double latitude)
    {
        Longitude = longitude;
        Latitude = latitude;
    }
}