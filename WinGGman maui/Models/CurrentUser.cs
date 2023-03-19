using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGGman_maui.Models
{
    public sealed class CurrentUser
    {
        private static readonly Lazy<CurrentUser> lazy = new Lazy<CurrentUser>(() => new CurrentUser());

        public static CurrentUser Instance { get { return lazy.Value; } }
        
        public string UserName { get; set; }
        public string Platform { get; set; }

        private CurrentUser() 
        {
            
        }
        


        //public static CurrentUser GetUserNamePlatform()
        //{
        //    return _instance;

        //}

        //public void SetUserNamePlatform(string userName, string platform)
        //{
        //    UserName = userName;
        //    Platform = platform;

        //}
    }
}
