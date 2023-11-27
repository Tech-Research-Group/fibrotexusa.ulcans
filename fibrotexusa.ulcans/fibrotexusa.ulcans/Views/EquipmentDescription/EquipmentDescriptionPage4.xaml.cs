using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage4 : ContentPage
    {
        public EquipmentDescriptionPage4()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage3 destination = new EquipmentDescriptionPage3();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage5 destination = new EquipmentDescriptionPage5();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
