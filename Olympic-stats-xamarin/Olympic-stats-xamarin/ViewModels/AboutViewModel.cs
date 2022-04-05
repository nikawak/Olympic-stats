using Olympic_stats_xamarin.Models;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        /*public event PropertyChangedEventHandler PropertyChanged;
        private new void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }*/
        public string str { get; set; }
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(() => {  });

        }

        private bool isToggled;
        public bool IsToggled
        {
            get => isToggled;
            set
            {
                isToggled = value;
                if (isToggled)
                {
                    Settings.Theme = OSAppTheme.Dark;
                }
                else if(!isToggled)
                {
                    Settings.Theme = OSAppTheme.Light;
                }
                Settings.SetSettings();
                //OnPropertyChanged();
            }
        }
        public ICommand OpenWebCommand { get; }
    }
}