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
        
        
        

		CurrentUser.Instance.UserName = userName.Text;
		CurrentUser.Instance.Platform = platform.Text;
		



        await Navigation.PushAsync(new Views.PlayerStatsPage());
    }
}

