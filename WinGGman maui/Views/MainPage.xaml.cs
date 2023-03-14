using WinGGman_maui.Models;
using WinGGman_maui.ViewModels;

namespace WinGGman_maui;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    public async void GetDataOnMainPageButtonClicked(object sender, EventArgs e)
    {

		CurrentUser.UserName = userName.Text;
		CurrentUser.Platform = platform.Text;
		//SessionData.Player = PlayerStatsPageViewModel.GetData($"{SessionData.Platform}/{SessionData.UserName}/segments/legend");



        await Navigation.PushAsync(new Views.PlayerStatsPage());
    }
}

