using WinGGman_maui.Models;
using WinGGman_maui.ViewModels;

namespace WinGGman_maui.Views;

public partial class LegendDetailPage : ContentPage
{
	public LegendDetailPage()
	{
		InitializeComponent();


		double kills = double.Parse(killsValue.Text);
		double matchesPlayed = double.Parse(matchesPlayedValue.Text);

		KDR.Text = (kills / matchesPlayed).ToString();
	}
}