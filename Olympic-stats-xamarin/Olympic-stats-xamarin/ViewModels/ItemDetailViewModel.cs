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
        /*public ItemDetailViewModel()
        {
            BindingContext = ElephantData.Elephants.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
        }*/

        private string id;
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


        public string ItemId
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

        public async void LoadItemId(string ItemId)
        {
            try
            {
                var Item = await DataStore.GetItemAsync(ItemId);
                id = Item.Id;
                Name = Item.Name;
                SurName = Item.SurName;
                FunctionalClass = Item.FunctionalClass;
                Sex = Item.Sex;
                
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
