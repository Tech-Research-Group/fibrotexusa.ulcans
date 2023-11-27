using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage6 : ContentPage
    {
        public EquipmentDescriptionPage6()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage5 destination = new EquipmentDescriptionPage5();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage7 destination = new EquipmentDescriptionPage7();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
