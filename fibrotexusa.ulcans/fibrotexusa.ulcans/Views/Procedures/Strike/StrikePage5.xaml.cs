using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures.Strike
{
    public partial class StrikePage5 : ContentPage
    {
        public StrikePage5()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            StrikePage4 destination = new StrikePage4();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
