using BichoSemDono.Core.Authentication.Token;
using BichoSemDono.Core.Infrastructure.ContextConfiguration;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BichoSemDono.Application.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, ActionResult<string>>
{
    private readonly BichoSemDonoContext _context;
    private readonly TokenService _tokenService;

    public LoginCommandHandler(BichoSemDonoContext context, TokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public async Task<ActionResult<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u =>
            (u.Email != null && u.Email.ToLower().Equals(request.UserIdentification)) ||
            (u.Phone != null && u.Phone.Equals(request.UserIdentification)), cancellationToken: cancellationToken);

        if (user is null)
            return new NotFoundResult();

        return _tokenService.GenerateToken(user);
    }
}