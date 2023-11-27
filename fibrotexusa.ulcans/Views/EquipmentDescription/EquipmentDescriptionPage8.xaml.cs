using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage8 : ContentPage
    {
        public EquipmentDescriptionPage8()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage7 destination = new EquipmentDescriptionPage7();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage9 destination = new EquipmentDescriptionPage9();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
