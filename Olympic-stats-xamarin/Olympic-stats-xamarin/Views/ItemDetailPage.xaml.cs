using Olympic_stats_xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.Views
{
    public partial class SportsmanEditPage : ContentPage
    {
        public SportsmanEditPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}