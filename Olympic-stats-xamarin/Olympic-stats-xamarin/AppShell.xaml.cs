using Olympic_stats_xamarin.ViewModels;
using Olympic_stats_xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Olympic_stats_xamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SportsmanEditPage), typeof(SportsmanEditPage));
            Routing.RegisterRoute(nameof(NewSportsmanPage), typeof(NewSportsmanPage));
            Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
            Routing.RegisterRoute(nameof(SportsmanResultsPage), typeof(SportsmanResultsPage));
        }

    }
}
