using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BichoSemDono.Application.Login;

public struct LoginCommand : IRequest<ActionResult<string>>
{
    public string UserIdentification { get; init; }
    public string Password { get; init; }

    public LoginCommand(string userIdentification, string password)
    {
        UserIdentification = userIdentification;
        Password = password;
    }
}