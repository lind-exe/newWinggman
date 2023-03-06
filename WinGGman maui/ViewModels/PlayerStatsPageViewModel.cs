using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WinGGman_maui.Models;

namespace WinGGman_maui.ViewModels
{
    internal partial class PlayerStatsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        PlayerStats player;

        public async Task GetData(string uri)
        {
            string apiKey = "1b0e4531-fafa-459f-95a1-b892bc373737";

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://public-api.tracker.gg/v2/apex/standard/profile/");
            client.DefaultRequestHeaders.Add("TRN-Api-Key", apiKey);

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                Player = (JsonSerializer.Deserialize<PlayerStats>(responseString));
            }
        }
    }
}
