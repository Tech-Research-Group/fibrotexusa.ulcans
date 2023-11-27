using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.CriticalConsiderations
{
    public partial class CriticalConsiderationsPage4 : ContentPage
    {
        public CriticalConsiderationsPage4()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            CriticalConsiderationsPage3 destination = new CriticalConsiderationsPage3();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            CriticalConsiderationsPage5 destination = new CriticalConsiderationsPage5();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
