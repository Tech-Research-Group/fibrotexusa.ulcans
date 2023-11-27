using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void OnCalculatorBtn_Clicked(object sender, EventArgs e)
        {
            Configuration.CalculatorPage destination = new Configuration.CalculatorPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        async void OnEquipmentDescBtnClicked(object sender, EventArgs e)
        {
            EquipmentDescription.EquipmentDescriptionPage destination = new EquipmentDescription.EquipmentDescriptionPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        async void OnCamoBasicsBtnClicked(object sender, EventArgs e)
        {
            CriticalConsiderations.CriticalConsiderationsPage destination = new CriticalConsiderations.CriticalConsiderationsPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        async void OnTypicalConfigBtn_Clicked(object sender, EventArgs e)
        {
            Configuration.TypicalConfigPage destination = new Configuration.TypicalConfigPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        async void OnProceduresBtn_Clicked(object sender, EventArgs e)
        {
            Procedures.ProceduresPage destination = new Procedures.ProceduresPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        async void OnAdvConfigurationBtn_Clicked(object sender, EventArgs e)
        {
            Configuration.ConfigListPage destination = new Configuration.ConfigListPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        async void OnMaintenanceBtnClicked(object sender, EventArgs e)
        {
            Maintenance.MaintenancePage destination = new Maintenance.MaintenancePage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }

        async void OnReferencesBtnClicked(object sender, EventArgs e)
        {
            References.ReferencesPage destination = new References.ReferencesPage();
            await Navigation.PushAsync(destination, false)
                            .ConfigureAwait(false);
        }
    }
}
