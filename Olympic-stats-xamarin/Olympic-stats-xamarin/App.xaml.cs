using Olympic_stats_xamarin.Services;
using Olympic_stats_xamarin.Models;
using Olympic_stats_xamarin.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Olympic_stats_xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Settings.SetSettings();
        }

        protected override void OnSleep()
        {
            Settings.SetSettings();
        }

        protected override void OnResume()
        {
            Settings.SetSettings();
        }

    }
}
