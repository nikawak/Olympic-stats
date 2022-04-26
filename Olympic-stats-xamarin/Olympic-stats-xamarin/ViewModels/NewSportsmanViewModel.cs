using Olympic_stats_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    public class NewSportsmanViewModel : BaseViewModel
    {
        private string name;
        private string surName;
        private string functionalClass;
        private string sex;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public string SurName
        {
            get => surName;
            set => SetProperty(ref surName, value);
        }
        public string FunctionalClass
        {
            get => functionalClass;
            set => SetProperty(ref functionalClass, value);
        }

        public string Sex
        {
            get => sex;
            set => SetProperty(ref sex, value);
        }

        public NewSportsmanViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return name != null
                && surName != null
                && functionalClass != null
                && sex != null;
        }

        

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Sportsman newItem = new Sportsman()
            {
                Name = name,
                SurName = surName,
                FunctionalClass = functionalClass,
                Sex = sex
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack

            await Shell.Current.GoToAsync("..");
        }
    }
}
