using BichoSemDono.Core.Infrastructure.ContextConfiguration;
using BichoSemDono.Domain.User.Entities;
using BichoSemDono.Domain.User.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BichoSemDono.Application.Signup;

public class SignupCommandHandler : IRequestHandler<SignupCommand, Guid>
{
    private readonly BichoSemDonoContext _context;

    public SignupCommandHandler(BichoSemDonoContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(SignupCommand request, CancellationToken cancellationToken)
    {
        var userAlreadyExists = await _context.Users.AnyAsync(u =>
                (u.Email != null && u.Email.Address.Equals(request.EmailAddress)) ||
                (u.Phone != null && u.Phone.Equals(request.Phone)),
            cancellationToken: cancellationToken);

        if (userAlreadyExists)
            throw new Exception("emailOrPhoneAlreadyRegistered");

        var user = new BaseUser(
            name: request.Name,
            petsQuantity: request.PetsQuantity,
            password: request.Password,
            profile: request.UserProfile,
            email: request.EmailAddress != null ? new Email(request.EmailAddress) : null,
            phone: request.Phone != null ? new Phone(request.Phone) : null
        );

        await _context.Users.AddAsync(user, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}