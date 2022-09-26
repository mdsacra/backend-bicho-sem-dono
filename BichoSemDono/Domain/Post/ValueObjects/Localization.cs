using BichoSemDono.Core.Architecture;

namespace BichoSemDono.Domain.Post.ValueObjects;

public class Localization : ValueObject<Localization>
{
    public string Latitude { get; private set; }
    public string Longitude { get; private set; }
    public string Address { get; private set; }

    public Localization(string latitude, string longitude, string address)
    {
        Latitude = latitude;
        Longitude = longitude;
        Address = address;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Latitude;
        yield return Longitude;
    }
}