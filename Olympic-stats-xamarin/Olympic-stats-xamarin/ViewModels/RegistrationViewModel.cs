using Olympic_stats_xamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        public RegistrationViewModel()
        {
            LoginCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            });
        }
        public Command LoginCommand { get; }
    }
}