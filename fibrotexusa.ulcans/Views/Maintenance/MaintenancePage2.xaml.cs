using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Maintenance
{
    public partial class MaintenancePage2 : ContentPage
    {
        public MaintenancePage2()
        {
            InitializeComponent();

            /* Repair Using Cable Ties Link */
            var repairCableTiesBtn_tap = new TapGestureRecognizer();
            repairCableTiesBtn_tap.Tapped += (s, e) =>
            {
                MaintenancePage destination = new MaintenancePage();
                Navigation.PushAsync(destination, false).ConfigureAwait(false);
            };
            repairCableTiesBtn.GestureRecognizers.Add(repairCableTiesBtn_tap);
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            MaintenancePage destination = new MaintenancePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            MaintenancePage3 destination = new MaintenancePage3();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
