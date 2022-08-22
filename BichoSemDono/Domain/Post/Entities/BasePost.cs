using BichoSemDono.Domain.Post.ValueObjects;
using BichoSemDono.Domain.Shared.Entities;
using BichoSemDono.Domain.User.Entities;

namespace BichoSemDono.Domain.Post.Entities;

public class BasePost
{
    public Guid Id { get; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; }
    public DateTime? FinishedAt { get; private set; }
    public Localization Localization { get; private set; }
    public Guid? PublisherId { get; }
    public virtual BaseUser? Publisher { get; }
    public virtual bool IsAnonymous => Publisher == null;
    
    public BasePost(string description, Localization localization, BaseUser? publisher)
    {
        Id = Guid.NewGuid();
        Description = description;
        Localization = localization;
        PublisherId = publisher?.Id;
        CreatedAt = DateTime.UtcNow;
    }
}