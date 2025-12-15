namespace Maui_Converter.MVVM.Views;

public partial class InformationPage : ContentPage
{
	public InformationPage()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuView());
    }
}