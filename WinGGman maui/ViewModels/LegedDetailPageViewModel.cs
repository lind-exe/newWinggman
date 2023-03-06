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

        [ObservableProperty]            
        Metadata metadata;

        [ObservableProperty]
        Attributes attributes;

        [ObservableProperty]
        Stats stats;
        
        [ObservableProperty]
        PlayerStats player;


        public LegedDetailPageViewModel()
        {            
                     
        }
    }
}
