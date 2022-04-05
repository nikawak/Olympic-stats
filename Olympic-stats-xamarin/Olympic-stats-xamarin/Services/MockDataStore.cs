using Olympic_stats_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.Services
{
    public class MockDataStore : IDataStore<Sportsman>
    {
        readonly List<Sportsman> Items;
        
        public MockDataStore()
        {
            Items = new List<Sportsman>()
            {
                new Sportsman() { Id = 1.ToString(), Name = "Item 1", SurName="Surname 1", FunctionalClass="T32", Sex="Мужской", Image = "cursed_cat.png" },
                new Sportsman() { Id = 2.ToString(), Name = "Item 2", SurName="Surname 2", FunctionalClass="T12", Sex="Женский", Image = "img.png" },
                new Sportsman() { Id = 3.ToString(), Name = "Item 3", SurName="Surname 3", FunctionalClass="T39", Sex="Мужской", Image = "cursed_cat.png" },
                new Sportsman() { Id = 4.ToString(), Name = "Item 4", SurName="Surname 4", FunctionalClass="F11", Sex="Мужской", Image = "img.png" },
            };
        }

        public async Task<bool> AddItemAsync(Sportsman Item)
        {
            Items.Add(Item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Sportsman Item)
        {
            var oldItem = Items.Where((Sportsman arg) => arg.Id == Item.Id).FirstOrDefault();
            Items.Remove(oldItem);
            Items.Add(Item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = Items.Where((Sportsman arg) => arg.Id == id).FirstOrDefault();
            Items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Sportsman> GetItemAsync(string id)
        {
            return await Task.FromResult(Items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Sportsman>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Items);
        }
        public int Count()
        {
            return Items.Count;
        }
    }
}