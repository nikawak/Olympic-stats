using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Olympic_stats_xamarin.Models
{
    internal class Settings
    {
        private static Settings uniqueInstance;
        public static Settings Instance
        {
            get
            {
                if (uniqueInstance != null) return uniqueInstance;
                uniqueInstance = new Settings();
                return uniqueInstance;
            }
        }

        private OSAppTheme theme;
        public OSAppTheme Theme
        {
            set
            {
                theme = value;
                SetTheme(value);
            }
            get
            {
                return theme;
            }
        }
        

        private Settings()
        {
            SetTheme(OSAppTheme.Dark);
        }
        private void SetTheme(OSAppTheme theme)
        {
            App.Current.UserAppTheme = theme;
        }

        
    }
}
