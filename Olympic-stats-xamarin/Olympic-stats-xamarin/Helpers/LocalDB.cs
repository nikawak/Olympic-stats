using Olympic_stats_xamarin.Models;
using Xamarin.Essentials;
using System.IO;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Olympic_stats_xamarin.Helpers
{
    internal static class LocalDB
    {
        public static SQLiteAsyncConnection Database { get; set; }

        static LocalDB()
        {
            //File.Delete(Path.Combine(FileSystem.AppDataDirectory, "Sportsman_DataBase.db"));
            
        } 
        public static async Task Init()
        {
            if (Database != null) return;

            string PathDB = Path.Combine(FileSystem.AppDataDirectory, "Sportsman_DataBase.db");

            Database = new SQLiteAsyncConnection(PathDB);

            await Database.CreateTableAsync<SportResult>();
            await Database.CreateTableAsync<Sportsman>();
        }



        public static async Task Insert(object obj)
        {
            await Init();
            await Database.InsertAsync(obj);
        }
        public static async Task Delete(object obj)
        {
            await Init();
            await Database.DeleteAsync(obj);
        }
        public static async Task Update(object obj)
        {
            await Init();
            await Database.UpdateAsync(obj);
        }
        public static async Task<T> Get<T>(int id) where T : new()
        {
            await Init();
            return await Database.GetAsync<T>(id);
        }
        public static async Task<IEnumerable<T>> GetAll<T>() where T : new()
        {
            await Init();
            return await Database.Table<T>().ToListAsync();
        }

    }
}
