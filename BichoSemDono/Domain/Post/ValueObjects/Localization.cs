﻿using BichoSemDono.Core.Architecture;

namespace BichoSemDono.Domain.Post.ValueObjects;

public class Localization : ValueObject<Localization>
{
    public string Latitude { get; private set; }
    public string Longitude { get; private set; }

    public Localization(string latitude, string longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Latitude;
        yield return Longitude;
    }
}