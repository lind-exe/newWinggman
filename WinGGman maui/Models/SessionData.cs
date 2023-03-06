using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGGman_maui.Models
{
    internal static class SessionData
    {
        public static List<PlayerStats> AllData { get; set; }

        public static string UserName { get; set; }
        public static string Platform { get; set; }
    }
}
