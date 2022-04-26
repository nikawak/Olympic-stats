using Olympic_stats_xamarin.Models;
using Olympic_stats_xamarin.ViewModels;
using Olympic_stats_xamarin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Olympic_stats_xamarin.Views
{
    public partial class SportsmansPage : ContentPage
    {
        SportsmansViewModel _viewModel;

        public SportsmansPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new SportsmansViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //_viewModel.OnAppearing();
        }
    }
}