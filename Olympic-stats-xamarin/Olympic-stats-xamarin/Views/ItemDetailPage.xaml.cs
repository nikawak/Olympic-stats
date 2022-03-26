using Olympic_stats_xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Olympic_stats_xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}