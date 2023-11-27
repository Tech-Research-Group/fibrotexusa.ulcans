using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures.Strike
{
    public partial class StrikePage2 : ContentPage
    {
        public StrikePage2()
        {
            InitializeComponent();
            /* Maintenance Link */
            var maintenanceBtn_tap = new TapGestureRecognizer();
            maintenanceBtn_tap.Tapped += (s, e) =>
            {
                Maintenance.MaintenancePage destination = new Maintenance.MaintenancePage();
                Navigation.PushAsync(destination, false).ConfigureAwait(false);
            };
            maintenanceBtn.GestureRecognizers.Add(maintenanceBtn_tap);
        }
        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            StrikePage destination = new StrikePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            StrikePage3 destination = new StrikePage3();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
