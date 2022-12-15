using BichoSemDono.Core.Architecture;

namespace BichoSemDono.Domain.User.ValueObjects;

public class Email : ValueObject<Email>
{
    public string Address { get; }

    public Email(string address)
    {
        Address = address;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Address;
    }
}