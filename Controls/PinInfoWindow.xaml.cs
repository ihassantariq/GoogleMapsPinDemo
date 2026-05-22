namespace GoogleMapsPinDemo.Controls;

public partial class PinInfoWindow : ContentView
{
    public static readonly BindableProperty PlaceNameProperty =
        BindableProperty.Create(nameof(PlaceName), typeof(string), typeof(PinInfoWindow), string.Empty);

    public static readonly BindableProperty AddressProperty =
        BindableProperty.Create(nameof(Address), typeof(string), typeof(PinInfoWindow), string.Empty);

    public static readonly BindableProperty CategoryProperty =
        BindableProperty.Create(nameof(Category), typeof(string), typeof(PinInfoWindow), string.Empty);

    public static readonly BindableProperty RatingProperty =
        BindableProperty.Create(nameof(Rating), typeof(string), typeof(PinInfoWindow), "0.0");

    public static readonly BindableProperty OpeningHoursProperty =
        BindableProperty.Create(nameof(OpeningHours), typeof(string), typeof(PinInfoWindow), string.Empty);

    public string PlaceName
    {
        get => (string)GetValue(PlaceNameProperty);
        set => SetValue(PlaceNameProperty, value);
    }

    public string Address
    {
        get => (string)GetValue(AddressProperty);
        set => SetValue(AddressProperty, value);
    }

    public string Category
    {
        get => (string)GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
    }

    public string Rating
    {
        get => (string)GetValue(RatingProperty);
        set => SetValue(RatingProperty, value);
    }

    public string OpeningHours
    {
        get => (string)GetValue(OpeningHoursProperty);
        set => SetValue(OpeningHoursProperty, value);
    }

    public PinInfoWindow()
    {
        InitializeComponent();
        BindingContext = this;
    }
}
