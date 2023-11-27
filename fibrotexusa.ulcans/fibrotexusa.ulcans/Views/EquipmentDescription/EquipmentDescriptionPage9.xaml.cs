using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage9 : ContentPage
    {
        public EquipmentDescriptionPage9()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage8 destination = new EquipmentDescriptionPage8();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
