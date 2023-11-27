using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.References
{
    public partial class ReferencesPage : ContentPage
    {
        public ReferencesPage()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            ReferencesPage2 destination = new ReferencesPage2();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
