namespace BichoSemDono.Application.Post.DTOs;

public struct LocalizationDto
{
    public string Latitude { get; init; }
    public string Longitude { get; init; }

    public LocalizationDto(string latitude, string longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
}