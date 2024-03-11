using ScanbotSDK.MAUI;
using ScanbotSDK.MAUI.Configurations;
using ScanbotSDK.MAUI.Constants;

namespace ScanbotBarcodeExample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void ScanBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        var configuration = new BarcodeScannerConfiguration
        {
            //BarcodeFormats = Models.BarcodeTypes.Instance.AcceptedTypes,
            CodeDensity = BarcodeDensity.High,
            EngineMode = EngineMode.NextGen,
            SuccessBeepEnabled = true
        };

        configuration.OverlayConfiguration = new SelectionOverlayConfiguration(
                    automaticSelectionEnabled: false,
                    overlayFormat: BarcodeTextFormat.Code,
                    polygon: Colors.Yellow,
                    text: Colors.Yellow,
                    textContainer: Colors.Black);


        var result = await ScanbotBarcodeSDK.BarcodeService.OpenBarcodeScannerView(configuration);

        if (result.Status == OperationResult.Ok)
        {

        }
    }
}


