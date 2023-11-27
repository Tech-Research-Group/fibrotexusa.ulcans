using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Maintenance
{
    public partial class MaintenancePage3 : ContentPage
    {
        public MaintenancePage3()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            MaintenancePage2 destination = new MaintenancePage2();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            MaintenancePage4 destination = new MaintenancePage4();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
