using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.EquipmentDescription
{
    public partial class EquipmentDescriptionPage2 : ContentPage
    {
        public EquipmentDescriptionPage2()
        {
            InitializeComponent();
        }

        private async void OnBackBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage destination = new EquipmentDescriptionPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        private async void OnNextBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescriptionPage3 destination = new EquipmentDescriptionPage3();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
