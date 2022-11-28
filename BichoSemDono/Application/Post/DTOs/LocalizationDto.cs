namespace BichoSemDono.Application.Post.DTOs;

public struct LocalizationDto
{
    public double Latitude { get; init; }
    public double Longitude { get; init; }
    public string Address { get; init; }

    public LocalizationDto(double latitude, double longitude, string address)
    {
        Latitude = latitude;
        Longitude = longitude;
        Address = address;
    }
}