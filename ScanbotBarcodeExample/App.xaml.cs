using ScanbotSDK.MAUI;
using ScanbotSDK.MAUI.Models;

namespace ScanbotBarcodeExample;

public partial class App : Application
{
    internal const string LicenseKey = "";

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        ScanbotBarcodeSDK.Initialize(new InitializationOptions
        {
            LicenseKey = LicenseKey,
            LoggingEnabled = true,
            ErrorHandler = (status, feature) =>
            {
                Console.WriteLine($"License error: {status}, {feature}");
            }
        });
    }
}

