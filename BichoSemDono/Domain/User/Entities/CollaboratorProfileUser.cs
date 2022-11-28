using BichoSemDono.Domain.User.Enums;

namespace BichoSemDono.Domain.User.Entities;

public class CollaboratorProfileUser : BaseUser
{
    public CollaboratorProfileUser(
        string name,
        int petsQuantity,
        string password,
        string? email,
        string? phone
        ) : base(name, petsQuantity, password, profile: UserProfile.Collaborator, email, phone)
    {
    }
}