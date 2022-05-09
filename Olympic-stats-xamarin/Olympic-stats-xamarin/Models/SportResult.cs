
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olympic_stats_xamarin.Models
{
    public class SportResult
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Sportsman_id { get; set; }
        public string Discipline { get; set; }
        public bool IsTime { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Range { get; set; }

        public SportResult() { }
    }
}
