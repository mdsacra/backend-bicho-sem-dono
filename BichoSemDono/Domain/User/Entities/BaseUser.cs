using BichoSemDono.Domain.Post.Entities;
using BichoSemDono.Domain.Shared.Entities;
using BichoSemDono.Domain.User.Enums;
using BichoSemDono.Domain.User.ValueObjects;

namespace BichoSemDono.Domain.User.Entities;

public class BaseUser
{
    public Guid Id { get; }
    public string Name { get; private set; }
    public int PetsQuantity { get; private set; }
    public string Password { get; private set; }
    public UserProfile Profile { get; private set; }
    public Email? Email { get; private set; }
    public Phone? Phone { get; private set; }
    
    // private List<Support> _supports = new();
    // public IReadOnlyCollection<Support> Supports => _supports;

    private List<BasePost> _posts = new();
    public IReadOnlyCollection<BasePost> BasePosts => _posts;
    public DateTime CreatedAt { get; }

    public BaseUser(string name, int petsQuantity, string password, UserProfile profile, Email? email, Phone? phone)
    {
        Id = Guid.NewGuid();
        Name = name;
        PetsQuantity = petsQuantity;
        Password = password;
        Profile = profile;
        Email = email;
        Phone = phone;
        CreatedAt = DateTime.UtcNow;
    }
}