using BichoSemDono.Domain.User.Enums;
using MediatR;

namespace BichoSemDono.Application.Signup;

public struct SignupCommand : IRequest<Guid>
{
    public string? EmailAddress { get; init; }
    public string? Phone { get; init; }
    public string Name { get; init; }
    public int PetsQuantity { get; init; }
    public UserProfile UserProfile { get; init; }
    public string Password { get; init; }

    public SignupCommand(
        string? emailAddress,
        string? phone,
        string name,
        int petsQuantity,
        UserProfile userProfile,
        string password)
    {
        if (emailAddress is null && phone is null)
            throw new Exception("emailOrPhoneMustHaveValue");

        if (password.Length < 6)
            throw new Exception("passwordMustBeAtLeast6CharactersLong");
        
        EmailAddress = emailAddress;
        Phone = phone;
        Name = name;
        PetsQuantity = petsQuantity;
        UserProfile = userProfile;
        Password = password;
    }
}