namespace Maui_Converter.MVVM.Views;

public partial class VolumePage : ContentPage
{
	public VolumePage()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuView());
    }
}