using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures.Erect
{
    public partial class ErectPage5 : ContentPage
    {
        public ErectPage5()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            ErectPage4 destination = new ErectPage4();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            ErectPage6 destination = new ErectPage6();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
