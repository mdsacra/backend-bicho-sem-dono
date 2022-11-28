using BichoSemDono.Domain.User.Enums;

namespace BichoSemDono.Domain.User.Entities;

public class ProtectorProfileUser : BaseUser
{
    public ProtectorProfileUser(
        string name,
        int petsQuantity,
        string password,
        string? email,
        string? phone
        ) : base(name, petsQuantity, password, profile: UserProfile.Protector, email, phone)
    {
    }
}