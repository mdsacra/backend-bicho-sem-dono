using BichoSemDono.Application.Post.QuerySide.ViewModels;
using MediatR;

namespace BichoSemDono.Application.Post.QuerySide.Queries;

public struct ListOwnerlessPetPostsQuery : IRequest<IEnumerable<OwnerlessPetPostViewModel>> { }