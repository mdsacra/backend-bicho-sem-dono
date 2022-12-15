using BichoSemDono.Core.Architecture;

namespace BichoSemDono.Domain.Post.ValueObjects;

public class Localization : ValueObject<Localization>
{
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }
    public string Address { get; private set; }

    public Localization(double latitude, double longitude, string address)
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