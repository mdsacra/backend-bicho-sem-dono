using BichoSemDono.Domain.Post.Entities;
using BichoSemDono.Domain.User.Entities;

namespace BichoSemDono.Domain.Shared.Entities;

public class Support
{
    public Guid PostId { get; }
    public virtual BasePost Post { get; } = null!;
    public Guid UserId { get; }
    public virtual BaseUser User { get; } = null!;

    public Support(BasePost post, BaseUser user)
    {
        PostId = post.Id;
        UserId = user.Id;
    }
}