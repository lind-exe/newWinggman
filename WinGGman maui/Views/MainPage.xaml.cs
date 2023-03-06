using WinGGman_maui.Models;

namespace WinGGman_maui;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    public async void GetDataOnMainPageButtonClicked(object sender, EventArgs e)
    {

		SessionData.UserName = userName.Text;
		SessionData.Platform = platform.Text;

		


		await Navigation.PushAsync(new Views.PlayerStatsPage());
    }
}

