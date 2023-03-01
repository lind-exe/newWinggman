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
		
		
		//PlayerStats.GetData($"{platform.Text}/{userName.Text}/segments/legend");
		

		


		await Navigation.PushAsync(new Views.PlayerStatsPage());
    }
}

