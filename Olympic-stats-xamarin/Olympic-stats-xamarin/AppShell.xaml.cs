﻿using Olympic_stats_xamarin.ViewModels;
using Olympic_stats_xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Olympic_stats_xamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
