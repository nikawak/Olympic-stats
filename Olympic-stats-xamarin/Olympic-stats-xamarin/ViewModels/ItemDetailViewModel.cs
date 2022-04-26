using Olympic_stats_xamarin.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private int id;
        private string name;
        private string surName;
        private string functionalClass;
        private string sex;
        private string image;

        private Sportsman Sportsman;

        public ItemDetailViewModel()
        {
            Title = "Change parametrs";
            SaveCommand = new Command(OnSave, OnValidate);
            CancelCommand = new Command(OnBack);
            DeleteCommand = new Command(OnDelete);
        }

        public Command CancelCommand { get; }
        public Command SaveCommand { get; }
        public Command DeleteCommand { get; }



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
        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }


        public int ItemId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(int ItemId)
        {
            try
            {
                var Item = await DataStore.GetItemAsync(ItemId);
                id = Item.Id;
                Name = Item.Name;
                SurName = Item.SurName;
                FunctionalClass = Item.FunctionalClass;
                Sex = Item.Sex;
                Image = Item.Image;


            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        public async void OnBack()
        {
            await Shell.Current.GoToAsync("..");
        }
        public async void OnSave()
        {
            Sportsman = new Sportsman()
            { Id = id, Name = name, SurName = surName, FunctionalClass = functionalClass, Sex = sex, Image = image };

            await DataStore.UpdateItemAsync(Sportsman);
            await Shell.Current.GoToAsync("..");
        }
        public async void OnDelete()
        {
            await DataStore.DeleteItemAsync(id);
            await Shell.Current.GoToAsync("..");
        }
        public bool OnValidate()
        {
            return true;
        }


        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set 
            { 
                isChecked = value;
                OnPropertyChanged();
            }
        }
    }
}
