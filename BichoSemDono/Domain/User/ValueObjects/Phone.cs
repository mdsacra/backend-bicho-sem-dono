using BichoSemDono.Core.Architecture;

namespace BichoSemDono.Domain.User.ValueObjects;

public class Phone : ValueObject<Phone>
{
    public string Ddd { get; }
    public string Number { get; }
    public bool IsWhatsapp { get; }

    public Phone(string ddd, string number, bool isWhatsapp)
    {
        Ddd = ddd;
        Number = number;
        IsWhatsapp = isWhatsapp;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Ddd;
        yield return Number;
        yield return IsWhatsapp;
    }
}