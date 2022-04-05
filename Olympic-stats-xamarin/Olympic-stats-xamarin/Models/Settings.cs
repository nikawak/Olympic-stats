using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.Models
{
    internal class Settings
    {

        public static OSAppTheme Theme { get; set; } = OSAppTheme.Light;
        public static void SetSettings()
        {
            App.Current.UserAppTheme = Theme;
        }
    }
}
