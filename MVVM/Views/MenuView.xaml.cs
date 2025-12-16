using Microsoft.VisualBasic;

namespace Maui_Converter.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
	}

    private async void OnInformationClicked (object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InformationPage());
    }

    private async void OnVolumeClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VolumePage());
    }
}