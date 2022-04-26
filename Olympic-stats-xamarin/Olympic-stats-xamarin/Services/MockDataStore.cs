using Olympic_stats_xamarin.Helpers;
using Olympic_stats_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.Services
{
    public class MockDataStore : IDataStore<Sportsman>
    {
        public List<Sportsman> Trash { get; set; } = new List<Sportsman>();
        
        public MockDataStore()
        {
           
        }

        public async Task<bool> AddItemAsync(Sportsman Item)
        {
            //Items.Add(Item);
            LocalDB.Instance.Database.Insert(Item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Sportsman Item)
        {
            //var oldItem = Items.Where((Sportsman arg) => arg.Id == Item.Id).FirstOrDefault();
            //var index = Items.IndexOf(oldItem);
            //Items[index] = Item;

            LocalDB.Instance.Database.Update(Item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            //var oldItem = Items.Where((Sportsman arg) => arg.Id == id).FirstOrDefault();
            //Items.Remove(oldItem);

            Debug.WriteLine(LocalDB.Instance.Database.Delete<Sportsman>(id));

            return await Task.FromResult(true);
        }

        public async Task<Sportsman> GetItemAsync(int id)
        {
            //return await Task.FromResult(Items.FirstOrDefault(s => s.Id == id));
            return await Task.FromResult(LocalDB.Instance.Database.Get<Sportsman>(id));
        }

        public async Task<IEnumerable<Sportsman>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(LocalDB.Instance.Database.Table<Sportsman>().ToList());
        }
        public int Count()
        {
            return LocalDB.Instance.Database.Table<Sportsman>().ToList().Count();
        }
    }
}