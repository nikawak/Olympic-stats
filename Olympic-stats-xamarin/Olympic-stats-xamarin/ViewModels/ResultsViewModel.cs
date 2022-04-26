using Olympic_stats_xamarin.Helpers;
using Olympic_stats_xamarin.Models;
using System;
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
        public Command ShowResult { get; }
        public ResultsViewModel()
        {
            OnAppearing();
            Title = "About";
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ShowResult = new Command(GetResult);

            DinamicBackgroundCommand = new Command(() => {

                App.Current.Resources["BgDinamic"] = Color
                .FromUint(Convert.ToUInt32(new Random().Next()));
            });
            var a = LocalDB.Instance;
        }

        public BindingList<Sportsman> ListSportsmans { get; set; }
        public BindingList<string> Initials { get; set; }
        public BindingList<string> DisciplinesValues { get; set; } = new BindingList<string>()
        {
            "Бег 60", "Бег 100", "Бег 200", "Бег 400", "Бег 800", "Бег 1500", "Бег 5000", "Бег 10000",
            "Прыжок в длинну", "Прыжок в высоту", "Прыжок тройной",
            "Метание диска 0.75", "Метание диска 1", "Метание диска 1.5", "Метание диска 2", 
            "Метание копья 0.4", "Метание копья 0.5", "Метание копья 0.6", "Метание копья 0.8",
            "Толкание ядра 2", "Толкание ядра 3", "Толкание ядра 4", "Толкание ядра 5", "Толкание ядра 6", "Толкание ядра 7.26", "Метание булавы 0.397",
        };
        public int SelectedIndex { get; set; }
        public int SelectedDisciplineValueIndex { get; set; }
        private string resultText = "";

        public string ResultText
        {
            get => resultText;
            set => SetProperty(ref resultText, value);
        }

        public async void OnAppearing()
        {
            await ExecuteLoadItemsCommand();
        }

        async Task ExecuteLoadItemsCommand()
        {
            ListSportsmans = new BindingList<Sportsman>();
            Initials = new BindingList<string>();

            var items = await DataStore.GetItemsAsync(true);

            foreach (var item in items)
            {
                ListSportsmans.Add(item);
            }

            foreach (var item in ListSportsmans)
            {
                Initials.Add($"{item.SurName} {item.Name.Substring(0, 1)}.");
            }
        }
        public void GetResult()
        {
            Command();
        }

        public void Command()
        {
            var sportsman = ListSportsmans[SelectedIndex];
            var FClass = sportsman.FunctionalClass;
            var sex = sportsman.Sex.ToLower()[0]; //первая буква пола
            var discipline = SelectedDisciplineValueIndex;
            var condition = 3; //ручной хронометраж

            SqlCommand commandID = new SqlCommand($"select * from Functional_classes where class = '{FClass}' and sex = '{sex}'", ServerDB.Instance.Connection);
            int id = Convert.ToInt32(commandID.ExecuteScalar());

            SqlCommand commandResult = new SqlCommand($"select * from Sports_category where class_id = {id} and discipline_id = {discipline+1}", ServerDB.Instance.Connection);
            SqlDataReader readerResult = commandResult.ExecuteReader();

            ResultText = "";
            while (readerResult.Read())
            {
                if(readerResult["time"] != DBNull.Value)
                {
                    TimeSpan time = (TimeSpan)readerResult["time"];
                    string category = (string)readerResult["name"];
                    ResultText += $"Разряд: {category} || Результат для получения: {time.Minutes}м:{time.Seconds}с.{time.Milliseconds}";
                   
                    if (readerResult["condition_id"].ToString() == "2")
                    {
                        ResultText += " в помещении";
                    }
                    ResultText += "\n";
                }
                else
                {
                    string category = (string)readerResult["name"];
                    var range = readerResult["range"];
                    ResultText += $"Разряд: {category} || Результат для получения: {range} метров\n";
                }
            }
            OnPropertyChanged();
            readerResult.Close();
        }
    }
}