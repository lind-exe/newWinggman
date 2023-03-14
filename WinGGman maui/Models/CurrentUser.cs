using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGGman_maui.Models
{
    public sealed class CurrentUser
    {
        public static string UserName { get; set; }
        public static string Platform { get; set; }
        



        private static CurrentUser instance = null;
        private static readonly object padlock = new object();

        CurrentUser()
        {
            
        }

        public static CurrentUser Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null) 
                    {
                        instance = new CurrentUser();   
                    }
                    return instance;
                }
            }
        }
    }
}
