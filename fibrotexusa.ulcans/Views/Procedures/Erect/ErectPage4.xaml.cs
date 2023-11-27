﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures.Erect
{
    public partial class ErectPage4 : ContentPage
    {
        public ErectPage4()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            ErectPage3 destination = new ErectPage3();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            ErectPage5 destination = new ErectPage5();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
