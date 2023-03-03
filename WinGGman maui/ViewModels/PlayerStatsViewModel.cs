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
    internal partial class PlayerStatsViewModel : ObservableObject
    {
        [ObservableProperty]
        PlayerStats allData;

        [ObservableProperty]            //dessa properties går att hitta i bindings men de innehåller ingen data. Skillnad på AllData.Datas.metadata && AllData.Datas.Metadata
        Metadata metadata;

        [ObservableProperty]
        Attributes attributes;

        [ObservableProperty]
        Stats stats;

        public PlayerStatsViewModel()
        {
            AllData = new PlayerStats();
        }

        public async Task GetData(string uri)
        {
            PlayerStats player = new PlayerStats();
            
            AllData.Datas = new List<Data>();
            string apiKey = "1b0e4531-fafa-459f-95a1-b892bc373737";

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://public-api.tracker.gg/v2/apex/standard/profile/");
            client.DefaultRequestHeaders.Add("TRN-Api-Key", apiKey);

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                player = (JsonSerializer.Deserialize<PlayerStats>(responseString));

                await Task.Delay(1000);
                player.data.ToList().ForEach(x => AllData.Datas.Add(x));
                await Task.Delay(5000);
            }
        }
    }
}
