using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.References
{
    public partial class ReferencesPage2 : ContentPage
    {
        public ReferencesPage2()
        {
            InitializeComponent();
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            ReferencesPage destination = new ReferencesPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            ReferencesPage3 destination = new ReferencesPage3();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
