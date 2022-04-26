using Olympic_stats_xamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command RegistrationCommand { get; }


        public LoginViewModel()
        {
            LoginCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"//{nameof(ResultsPage)}");
            });
            RegistrationCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"{nameof(RegistrationPage)}");
            });
        }
    }
}
