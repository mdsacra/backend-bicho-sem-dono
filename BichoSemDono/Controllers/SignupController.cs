using BichoSemDono.Application.Signup;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BichoSemDono.Controllers;

[ApiController]
[Route("api/signup")]
[AllowAnonymous]
public class SignupController : ControllerBase
{
    private readonly IMediator _mediator;

    public SignupController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> Signup([FromBody] SignupCommand command)
        => Created("", await _mediator.Send(command));
}