using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage7 : ContentPage
    {
        public EquipmentDescriptionPage7()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage6 destination = new EquipmentDescriptionPage6();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage8 destination = new EquipmentDescriptionPage8();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
