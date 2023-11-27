using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures.Erect
{
    public partial class ErectPage : ContentPage
    {
        public ErectPage()
        {
            InitializeComponent();

            /* Configuration Link */
            var configBtn_tap = new TapGestureRecognizer();
            configBtn_tap.Tapped += (s, e) =>
            {
                Configuration.TypicalConfigPage destination = new Configuration.TypicalConfigPage();
                Navigation.PushAsync(destination, false).ConfigureAwait(false);
            };
            configBtn.GestureRecognizers.Add(configBtn_tap);

            /* Equipment Description Link */
            var equipDescBtn_tap = new TapGestureRecognizer();
            equipDescBtn_tap.Tapped += (s, e) =>
            {
                EquipmentDescription.EquipmentDescriptionPage destination = new EquipmentDescription.EquipmentDescriptionPage();
                Navigation.PushAsync(destination, false).ConfigureAwait(false);
            };
            equipDescBtn.GestureRecognizers.Add(equipDescBtn_tap);
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            ProceduresPage destination = new ProceduresPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            BecketLacingPage destination = new BecketLacingPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
