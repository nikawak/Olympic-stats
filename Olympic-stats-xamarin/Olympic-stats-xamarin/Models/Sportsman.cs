using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.Models
{
    public class Sportsman
    {
        public string Id { get; set; }
        public ImageSource Image { get; set; } = "cursed_cat.png";
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FunctionalClass { get; set; }
        public string Sex { get; set; }
        public List<SportResult> Result { get; set; }

        public Sportsman()
        {
            Id = GetHashCode().ToString();
        }
        public override string ToString()
        {
            return $"{Name} {SurName} {FunctionalClass}";
        }
    }
}
