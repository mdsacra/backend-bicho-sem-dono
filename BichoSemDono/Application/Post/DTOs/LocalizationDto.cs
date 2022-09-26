using System.Net.Sockets;

namespace BichoSemDono.Application.Post.DTOs;

public struct LocalizationDto
{
    public string Latitude { get; init; }
    public string Longitude { get; init; }
    public string Address { get; init; }

    public LocalizationDto(string latitude, string longitude, string address)
    {
        Latitude = latitude;
        Longitude = longitude;
        Address = address;
    }
}