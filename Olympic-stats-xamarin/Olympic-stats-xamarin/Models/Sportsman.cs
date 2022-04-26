
using SQLite;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.Models
{
    public class Sportsman
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Image { get; set; } = "cursed_cat.png";
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FunctionalClass { get; set; }
        public string Sex { get; set; }

        public Sportsman() { }
        public override string ToString()
        {
            return $"{Name} {SurName} {FunctionalClass}";
        }
    }
}
