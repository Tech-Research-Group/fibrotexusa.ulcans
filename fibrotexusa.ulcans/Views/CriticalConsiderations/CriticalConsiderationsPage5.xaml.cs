﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.CriticalConsiderations
{
    public partial class CriticalConsiderationsPage5 : ContentPage
    {
        public CriticalConsiderationsPage5()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            CriticalConsiderationsPage4 destination = new CriticalConsiderationsPage4();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
