using BichoSemDono.Domain.User.Enums;
using BichoSemDono.Domain.User.ValueObjects;

namespace BichoSemDono.Domain.User.Entities;

public class AngelProfileUser : BaseUser
{
    public AngelProfileUser(
        string name,
        int petsQuantity,
        string password,
        Email? email,
        Phone? phone
        ) : base(name, petsQuantity, password, profile: UserProfile.Angel, email, phone)
    {
    }
}