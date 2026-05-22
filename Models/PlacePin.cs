namespace MauiGoogleMapsInfoWindow.Models;

/// <summary>
/// Represents a point of interest on the map with detailed information.
/// </summary>
public class PlacePin
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public double Rating { get; set; }
    public string OpeningHours { get; set; } = string.Empty;
}
