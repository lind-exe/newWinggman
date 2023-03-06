

using WinGGman_maui.Models;
using WinGGman_maui.ViewModels;

namespace WinGGman_maui.Views;

public partial class PlayerStatsPage : ContentPage
{
	
	public PlayerStatsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.PlayerStatsViewModel();

        // detta ger mig två listor, en allData och AllData?
    }

    bool pageStarted = false;
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (!pageStarted )
        {
            Task t = (BindingContext as PlayerStatsViewModel).GetData($"{SessionData.Platform}/{SessionData.UserName}/segments/legend"); // Metod i ViewModel
            
            

            pageStarted = true;
            
        }
    }

    private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var legend = ((ListView)sender).SelectedItem as Models.Data;
        if (legend != null)
        {
            var page = new LegendDetailPage();
            page.BindingContext = legend;
            await Navigation.PushAsync(page);
        }
    }
}