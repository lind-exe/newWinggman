using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinGGman_maui.Models;

namespace WinGGman_maui.ViewModels
{
    internal partial class LegedDetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        PlayerStats allData;

        [ObservableProperty]            //dessa properties går att hitta i bindings men de innehåller ingen data. Skillnad på AllData.Datas.metadata && AllData.Datas.Metadata
        Metadata metadata;

        [ObservableProperty]
        Attributes attributes;

        [ObservableProperty]
        Stats stats;


        public LegedDetailPageViewModel()
        {            
                     
        }
    }
}
