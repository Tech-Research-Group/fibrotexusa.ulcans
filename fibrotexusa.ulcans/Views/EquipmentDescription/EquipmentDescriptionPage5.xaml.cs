using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage5 : ContentPage
    {
        public EquipmentDescriptionPage5()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage4 destination = new EquipmentDescriptionPage4();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage6 destination = new EquipmentDescriptionPage6();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
