using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Procedures
{
    public partial class ProceduresPage : ContentPage
    {
        public ProceduresPage()
        {
            InitializeComponent();
        }

        async void OnErectBtn_Clicked(object sender, EventArgs e)
        {
            Erect.ErectPage destination = new Erect.ErectPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnStrikeBtn_Clicked(object sender, EventArgs e)
        {
            Strike.StrikePage destination = new Strike.StrikePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnBackBtnClicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
