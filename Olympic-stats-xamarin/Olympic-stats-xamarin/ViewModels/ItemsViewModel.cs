using Olympic_stats_xamarin.Models;
using Olympic_stats_xamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private Sportsman _selectedItem;

        public ObservableCollection<Sportsman> ListSportsmans { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Sportsman> ItemTapped { get; }

        public ItemsViewModel ()
        {
            Title = "Items";
            ListSportsmans = new ObservableCollection<Sportsman>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            OnAppearing();

            ItemTapped = new Command<Sportsman>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                ListSportsmans.Clear();
                var Items = await DataStore.GetItemsAsync(true);
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

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Sportsman SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        

        async void OnItemSelected(Sportsman Item)
        {
            if (Item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={Item.Id}");
        }
    }
}