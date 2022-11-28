using BichoSemDono.Domain.User.Enums;

namespace BichoSemDono.Domain.User.Entities;

public class AngelProfileUser : BaseUser
{
    public AngelProfileUser(
        string name,
        int petsQuantity,
        string password,
        string? email,
        string? phone
        ) : base(name, petsQuantity, password, profile: UserProfile.Angel, email, phone)
    {
    }
}