using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.CriticalConsiderations
{
    public partial class CriticalConsiderationsPage : ContentPage
    {
        public CriticalConsiderationsPage()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            CriticalConsiderationsPage2 destination = new CriticalConsiderationsPage2();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
