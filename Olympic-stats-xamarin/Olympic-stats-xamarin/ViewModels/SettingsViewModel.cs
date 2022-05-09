using Olympic_stats_xamarin.Models;
using Olympic_stats_xamarin.Views;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
            Title = "Настройки";
            LogoutCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            });
        }
        public Command LogoutCommand { get; }
       
        private bool isToggled = false;
        public bool IsToggled
        {
            get => isToggled;
            set
            {
                SetProperty(ref isToggled, value);
                if (isToggled)
                {
                    Settings.Instance.Theme = OSAppTheme.Dark;
                }
                else if (!isToggled)
                {
                    Settings.Instance.Theme = OSAppTheme.Light;
                }
            }
        }
    }
}