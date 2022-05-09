using Olympic_stats_xamarin.Models;
using Olympic_stats_xamarin.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Olympic_stats_xamarin.Helpers;
using Xamarin.Essentials;
using System.IO;
using System.Linq;

namespace Olympic_stats_xamarin.ViewModels
{
    public class SportsmansViewModel : BaseViewModel
    {
        private Sportsman _selectedItem;

        public ObservableCollection<Sportsman> ListSportsmans { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command PickPhoto { get; }
        public Command<Sportsman> ItemTappedCommand { get; }
        public Command<Sportsman> ItemTappedCommand2 { get; }
        public Command<Sportsman> DeleteItemCommand { get; }

        public SportsmansViewModel()
        {
            IsBusy = true;
            Title = "Ваши спортсмены";
            ListSportsmans = new ObservableCollection<Sportsman>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            PickPhoto = new Command<Sportsman>(OnPickPhoto);

            DeleteItemCommand = new Command<Sportsman>(OnDelete);

            ItemTappedCommand = new Command<Sportsman>(OnItemSelected);

            ItemTappedCommand2 = new Command<Sportsman>(OnItemSelected2);

            AddItemCommand = new Command(OnAddItem);
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(NewSportsmanPage)}");
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                ListSportsmans.Clear();
                var Items = await LocalDB.GetAll<Sportsman>();
                foreach (var Item in Items)
                {
                    ListSportsmans.Add(Item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        /*public void OnAppearing()
        {
            ExecuteLoadItemsCommand();
        }*/

        public Sportsman SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        public async void OnDelete(Sportsman Item)
        {          
            var res = await App.Current.MainPage.DisplayAlert("Вы уверены?", $"Удалить спортсмена {Item.Name}?", "Принять", "Отмена");
            if (res) 
            {
                var sr = await LocalDB.GetAll<SportResult>();
                var results = sr.Where(x => x.Sportsman_id == Item.Id);

                await LocalDB.Delete(Item);                

                foreach (var item in results)
                {
                    await LocalDB.Delete(item);
                }
                new FileInfo(Item.Image).Delete();
                await ExecuteLoadItemsCommand();
            }
        }

        async void OnPickPhoto(Sportsman sportsman)
        {
            try
            {
                if (true)
                {
                    var image = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
                    {
                        Title = "Выберите фото"
                    });
                    var stream = await image.OpenReadAsync();

                    var path = Path.Combine(FileSystem.AppDataDirectory, image.FileName);
                    stream.CopyTo(new FileStream(path, FileMode.OpenOrCreate));

                    sportsman.Image = path;
                }
            }
            catch (Exception) { }

            OnSave(sportsman);
        }
        public async void OnSave(Sportsman sportsman)
        {
            await LocalDB.Update(sportsman);
        }
        async void OnItemSelected(Sportsman Item)
        {
            if (Item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(SportsmanResultsPage)}?{nameof(SportsmanResultsViewModel.ItemId)}={Item.Id}");
        }
        async void OnItemSelected2(Sportsman Item)
        {
            if (Item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(SportsmanEditPage)}?{nameof(SportsmanEditViewModel.ItemId)}={Item.Id}");
        }
    }
}