using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Maintenance
{
    public partial class MaintenancePage : ContentPage
    {
        public MaintenancePage()
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
            MaintenancePage2 destination = new MaintenancePage2();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
