using Android.App;
using Android.Runtime;

namespace GoogleMapsPinDemo;

[Application]
[MetaData("com.google.android.maps.v2.API_KEY", Value = Constants.GoogleMapsApiKey)]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
