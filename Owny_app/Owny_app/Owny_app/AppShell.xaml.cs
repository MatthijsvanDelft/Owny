﻿using Owny_app.ViewModels;
using Owny_app.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Owny_app
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
