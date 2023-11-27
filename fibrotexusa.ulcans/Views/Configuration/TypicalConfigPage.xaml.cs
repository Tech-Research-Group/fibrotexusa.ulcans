using System;
using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Configuration
{
    public partial class TypicalConfigPage : ContentPage
    {
        public TypicalConfigPage()
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
            CalculatorPage destination = new CalculatorPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}
