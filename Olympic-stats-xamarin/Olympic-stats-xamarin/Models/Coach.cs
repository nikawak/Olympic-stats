using System;
using System.Collections.Generic;
using System.Text;

namespace Olympic_stats_xamarin.Models
{
    internal class Coach
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }    
        public string Password { get; set; }
    }
}
