using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures.Strike
{
    public partial class StrikePage3 : ContentPage
    {
        public StrikePage3()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            StrikePage2 destination = new StrikePage2();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            StrikePage4 destination = new StrikePage4();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}