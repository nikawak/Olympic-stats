using Olympic_stats_xamarin.Helpers;
using Olympic_stats_xamarin.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.ViewModels
{
    public class ResultsViewModel : BaseViewModel
    {
        public Command LoadItemsCommand { get; }
        public Command DinamicBackgroundCommand { get; }
        public Command ShowResultCommand { get; }
        public Command RefreshCommand { get; }

        public ResultsViewModel()
        {
            OnAppearing();
            Title = "Результаты";
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ShowResultCommand = new Command(GetResult);
            RefreshCommand = new Command(async() => await Refresh());

            ListSportsmans = new ObservableCollection<Sportsman>();
            Initials = new ObservableCollection<string>();
            SelectedIndex = 0;

            IsTime = true;
        }

        public ObservableCollection<Sportsman> ListSportsmans { get; set; }
        public ObservableCollection<string> Initials { get; set; }
        public ObservableCollection<string> DisciplinesValues { get; set; } = new ObservableCollection<string>()
        {
            "Бег 60", "Бег 100", "Бег 200", "Бег 400", "Бег 800", "Бег 1500", "Бег 5000", "Бег 10000",
            "Прыжок в длинну", "Прыжок в высоту", "Прыжок тройной",
            "Метание диска 0.75", "Метание диска 1", "Метание диска 1.5", "Метание диска 2", 
            "Метание копья 0.4", "Метание копья 0.5", "Метание копья 0.6", "Метание копья 0.8",
            "Толкание ядра 2", "Толкание ядра 3", "Толкание ядра 4", "Толкание ядра 5", "Толкание ядра 6", "Толкание ядра 7.26", "Метание булавы 0.397"
        };
        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { SetProperty(ref selectedIndex, value); }
        }
        private int selectedDisciplineValueIndex;
        public int SelectedDisciplineValueIndex
        {
            get { return selectedDisciplineValueIndex; }
            set { SetProperty(ref selectedDisciplineValueIndex, value); }
        }


        private bool isTime;
        public bool IsTime
        {
            get { return isTime; }
            set { SetProperty(ref isTime, value); }
        }


        private int? minutes;
        public int? Minutes
        {
            get { return minutes; }
            set { SetProperty(ref minutes, value); }
        }
        private int? seconds;
        public int? Seconds
        {
            get { return seconds; }
            set { SetProperty(ref seconds, value); }
        }
        private int? milliseconds;
        public int? Milliseconds
        {
            get { return milliseconds; }
            set { SetProperty(ref milliseconds, value); }
        }

        private int? meters;
        public int? Meters
        {
            get { return meters; }
            set { SetProperty(ref meters, value); }
        }
        private int? centimeters;
        public int? Centimeters
        {
            get { return centimeters; }
            set { SetProperty(ref centimeters, value); }
        }


        public string resultText;
        public string ResultText
        {
            get { return resultText; }
            set { SetProperty(ref resultText, value); }
        }



        public async void OnAppearing()
        {
            await ExecuteLoadItemsCommand();
        }
        public async Task Refresh()
        {
            await ExecuteLoadItemsCommand();

            if (SelectedDisciplineValueIndex <= 7)
                IsTime = true;
            else
                IsTime = false;
        }
        async Task ExecuteLoadItemsCommand()
        {
            var items = await LocalDB.GetAll<Sportsman>();

            ListSportsmans.Clear();
            Initials.Clear();
            
            foreach (var item in items)
            {
                ListSportsmans.Add(item);
                Initials.Add($"{item.SurName} {item.Name[0]}.");
                Debug.WriteLine(Initials[0]);
            }
            //OnPropertyChanged("Initials");
            //OnPropertyChanged("ListSportsman");
        }
        public void GetResult()
        {
            Command();
        }

        public async void Command()
        {
            var sportsman = ListSportsmans[SelectedIndex];
            var FClass = sportsman.FunctionalClass;
            var sex = sportsman.Sex.ToLower()[0]; //первая буква пола
            var discipline = SelectedDisciplineValueIndex;
            //var condition = 3; //ручной хронометраж

            SqlCommand commandID = new SqlCommand($"select * from Functional_classes where class = '{FClass}' and sex = '{sex}'", ServerDB.Instance.Connection);
            int id = Convert.ToInt32(commandID.ExecuteScalar());

            SqlCommand commandResult = new SqlCommand($"select * from Sports_category where class_id = {id} and discipline_id = {discipline+1}", ServerDB.Instance.Connection);
            SqlDataReader readerResult = commandResult.ExecuteReader();

            ResultText = "";
            var result = new SportResult();

            while (readerResult.Read())
            {
                if(readerResult["time"] != DBNull.Value)
                {
                    TimeSpan time = (TimeSpan)readerResult["time"];
                    string category = (string)readerResult["name"];
                    ResultText += $"Разряд: {category} || Результат: {time.Minutes}м:{time.Seconds}с.{time.Milliseconds}мс";
                   
                    if (readerResult["condition_id"].ToString() == "2")
                    {
                        ResultText += " в помещении";
                    }
                    ResultText += "\n";

                    if (!Minutes.HasValue) Minutes = 0;
                    if (!Seconds.HasValue) Seconds = 0;
                    if (!Milliseconds.HasValue) Milliseconds = 0;

                    result = new SportResult() { DateTime = DateTime.Now, Sportsman_id = sportsman.Id, IsTime = true, TimeSpan = new TimeSpan(0, 0, Minutes.Value, Seconds.Value, Milliseconds.Value), Discipline = DisciplinesValues[discipline] };
                
                }
                else
                {
                    string category = (string)readerResult["name"];
                    decimal range = (decimal)readerResult["range"];
                    ResultText += $"Разряд: {category} || Результат: {range} метров\n";

                    if (!Meters.HasValue) Meters = 0;
                    if (!Centimeters.HasValue) Centimeters = 0;

                    decimal resRange = Meters.Value + (decimal)Centimeters.Value/100;

                    result = new SportResult() { DateTime = DateTime.Now, Sportsman_id = sportsman.Id, IsTime = false, Range =  resRange, Discipline = DisciplinesValues[discipline]};
                
                }
            }
            
            readerResult.Close();
            await LocalDB.Insert(result);
            OnPropertyChanged();
        }
    }
}