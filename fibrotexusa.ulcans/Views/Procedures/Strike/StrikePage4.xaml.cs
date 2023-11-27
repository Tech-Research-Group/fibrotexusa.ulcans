using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures.Strike
{
    public partial class StrikePage4 : ContentPage
    {
        public StrikePage4()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            StrikePage3 destination = new StrikePage3();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            StrikePage5 destination = new StrikePage5();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
