using BichoSemDono.Domain.User.Enums;

namespace BichoSemDono.Domain.User.Entities;

public class BaseUser
{
    public Guid Id { get; }
    public string Name { get; private set; } = null!;
    public int PetsQuantity { get; private set; }
    public string Password { get; private set; } = null!;
    public UserProfile Profile { get; private set; }
    public string? Email { get; private set; }
    public string? Phone { get; private set; }
    
    // private List<Support> _supports = new();
    // public IReadOnlyCollection<Support> Supports => _supports;

    // private List<BasePost> _posts = new();
    // public IReadOnlyCollection<BasePost> BasePosts => _posts;
    public DateTime CreatedAt { get; }

    public BaseUser(string name, int petsQuantity, string password, UserProfile profile, string? email, string? phone)
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

    public BaseUser() { }
}