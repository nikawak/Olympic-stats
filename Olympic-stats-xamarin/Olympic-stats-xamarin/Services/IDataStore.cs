using Olympic_stats_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Olympic_stats_xamarin.Services
{
    public interface IDataStore<Sportsman>
    {
        Task<bool> AddItemAsync(Sportsman Item);
        Task<bool> UpdateItemAsync(Sportsman Item);
        Task<bool> DeleteItemAsync(string id);
        Task<Sportsman> GetItemAsync(string id);
        Task<IEnumerable<Sportsman>> GetItemsAsync(bool forceRefresh = false);
        int Count();
    }
}
