using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.CriticalConsiderations
{
    public partial class CriticalConsiderationsPage2 : ContentPage
    {
        public CriticalConsiderationsPage2()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            CriticalConsiderationsPage destination = new CriticalConsiderationsPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            CriticalConsiderationsPage3 destination = new CriticalConsiderationsPage3();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
