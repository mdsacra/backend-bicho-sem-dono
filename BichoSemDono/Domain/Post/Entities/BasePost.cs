using BichoSemDono.Domain.Post.ValueObjects;
using BichoSemDono.Domain.Shared.Entities;
using BichoSemDono.Domain.User.Entities;

namespace BichoSemDono.Domain.Post.Entities;

public class BasePost
{
    public Guid Id { get; }
    public string Description { get; private set; } = null!;
    public DateTime CreatedAt { get; }
    public DateTime? FinishedAt { get; private set; }
    public Localization Localization { get; private set; } = null!;
    
    public BasePost(string description, Localization localization)
    {
        Id = Guid.NewGuid();
        Description = description;
        Localization = localization;
        CreatedAt = DateTime.UtcNow;
    }
    
    public BasePost() { }
}