# Google Maps Pin Demo

A .NET MAUI app demonstrating how to display custom map pins with info windows using Google Maps.

## Features

- Display multiple custom pins on a Google Map
- Tap a pin to view a custom info window
- Navigate to a detail page for each pin
- Runs on Android, iOS, and Mac Catalyst

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or VS Code with the .NET MAUI workload
- A [Google Maps API key](https://developers.google.com/maps/documentation/android-sdk/get-api-key)

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/imhassantariq/GoogleMapsPinDemo.git
   cd GoogleMapsPinDemo
   ```

2. Open `Constants.cs` and replace `YOUR_GOOGLE_MAPS_API_KEY` with your actual Google Maps API key:
   ```csharp
   public const string GoogleMapsApiKey = "YOUR_GOOGLE_MAPS_API_KEY";
   ```

3. Build and run on your target platform:
   ```bash
   dotnet build
   ```

## Dependencies

- [Onion.Maui.GoogleMaps](https://github.com/themronion/Maui.GoogleMaps) — Google Maps control for .NET MAUI

## License

MIT
