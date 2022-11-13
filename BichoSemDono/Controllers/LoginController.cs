using BichoSemDono.Application.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BichoSemDono.Controllers;

[ApiController]
[Route("api/login")]
public class LoginController : ControllerBase
{
    private readonly IMediator _mediator;

    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<string>> Login([FromBody] LoginCommand loginCommand)
        => Ok(await _mediator.Send(loginCommand));
}