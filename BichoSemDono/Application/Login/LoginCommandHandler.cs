using BichoSemDono.Core.Authentication.Token;
using BichoSemDono.Core.Infrastructure.ContextConfiguration;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BichoSemDono.Application.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
{
    private readonly BichoSemDonoContext _context;

    public LoginCommandHandler(BichoSemDonoContext context)
    {
        _context = context;
    }

    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u =>
            (u.Email != null && u.Email.ToLower().Equals(request.UserIdentification)) ||
            (u.Phone != null && u.Phone.Equals(request.UserIdentification)), cancellationToken: cancellationToken);

        if (user is null) return "userNotFound";

        if (!request.Password.Equals(user.Password)) return "invalidData";
        
        return TokenService.GenerateToken(user);
    }
}