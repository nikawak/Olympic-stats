using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Olympic_stats_xamarin.Helpers;
using Olympic_stats_xamarin.Models;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    internal class SportsmanResultsViewModel:BaseViewModel
    {
        private int id;

        public Command LoadItemsCommand { get; }
        public Command<SportResult> DeleteItemCommand { get; }

        public SportsmanResultsViewModel()
        {
            Title = "Спортивные результаты";
            Results = new ObservableCollection<SportResult>();
            OnAppearing();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            DeleteItemCommand = new Command<SportResult>(OnDelete);
            
        }

        private async void OnAppearing()
        {
            await ExecuteLoadItemsCommand();
        }
        private async void OnDelete(SportResult result)
        {
            await LocalDB.Delete(result);
            await ExecuteLoadItemsCommand();
        }

        public ObservableCollection<SportResult> Results { get; set; }
        public int ItemId 
        {
            get { return id; }
            set { SetProperty(ref id, value); } 
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                var sr = await LocalDB.GetAll<SportResult>();
                var results = sr.Where(x => x.Sportsman_id == ItemId);
                Results.Clear();
                foreach(var res in results)
                {  
                    Results.Add(res);
                    Debug.WriteLine(res.Sportsman_id+"\n");
                    OnPropertyChanged();
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
            await Task.FromResult(true);
        }
    }
}
