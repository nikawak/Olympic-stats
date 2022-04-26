using System;
using System.Collections.Generic;
using System.Text;
using Olympic_stats_xamarin.Models;
using Xamarin.Essentials;
using System.IO;
using System.Diagnostics;
using Xamarin.Forms;
using SQLite;

namespace Olympic_stats_xamarin.Helpers
{
    internal class LocalDB
    {
        private static LocalDB uniqueInstance;
        public static LocalDB Instance 
        {
            get
            { 
                if (uniqueInstance == null) 
                {
                    uniqueInstance = new LocalDB(); 
                } 
                return uniqueInstance; 
            }
        }
        public SQLiteConnection Database { get; set; }

        private LocalDB()
        {
            
            string PathDB = Path.Combine(FileSystem.AppDataDirectory, "Sportsman_DataBase.db");

            Database = new SQLiteConnection(PathDB);

            Database.CreateTable<SportResult>();
            Database.CreateTable<Sportsman>(); 

        } 
    }
}
