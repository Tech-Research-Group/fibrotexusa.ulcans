using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage : ContentPage
    {
        public EquipmentDescriptionPage()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage2 destination = new EquipmentDescriptionPage2();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
