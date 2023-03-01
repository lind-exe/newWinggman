

namespace WinGGman_maui.Views;

public partial class PlayerStatsPage : ContentPage
{
	
	public PlayerStatsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.PlayerStatsViewModel();
    }

    bool pageStarted = false;
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (!pageStarted )
        {
            Task t = (BindingContext as ViewModels.PlayerStatsViewModel).GetData("origin/thelindd/segments/legend"); // Metod i ViewModel
            pageStarted = true;
            
        }
    }

    private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var legend = ((ListView)sender).SelectedItem as Models.PlayerStats;
        if (legend != null)
        {
            var page = new LegendDetailPage();
            page.BindingContext = legend;
            await Navigation.PushAsync(page);
        }
    }
}