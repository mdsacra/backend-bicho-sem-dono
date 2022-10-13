using BichoSemDono.Application.Post.CommandSide.Commands;
using BichoSemDono.Application.Post.QuerySide.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BichoSemDono.Controllers;

[ApiController]
[Route("api/ownerless-pet-post")]
public class OwnerlessPetPostController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public OwnerlessPetPostController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Guid>>> ListOwnerlesPetPosts(
        [FromQuery] double longitude, 
        [FromQuery] double latitude)
        => Ok(await _mediator.Send(new ListOwnerlessPetPostsQuery(longitude, latitude)));
    
    [HttpPost]
    public async Task<ActionResult<Guid>> CreateOwnerlessPetPost([FromBody] CreateOwnerlessPetPostCommand command)
        => Ok(await _mediator.Send(command));
}