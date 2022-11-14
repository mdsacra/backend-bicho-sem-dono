using BichoSemDono.Core.Architecture;

namespace BichoSemDono.Domain.User.ValueObjects;

public class Phone : ValueObject<Phone>
{
    public string Ddd { get; }
    public string Number { get; }

    public string Full => Ddd + Number;

    public Phone(string fullNumber)
    {
        Ddd = fullNumber[..2];
        Number = fullNumber[2..];
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Ddd;
        yield return Number;
    }
}