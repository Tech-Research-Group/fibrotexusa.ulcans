using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

using fibrotexusa.ulcans.Models;

namespace fibrotexusa.ulcans.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        readonly Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Home:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                    case (int)MenuItemType.Configuration:
                        MenuPages.Add(id, new NavigationPage(new Configuration.TypicalConfigPage()));
                        break;
                    case (int)MenuItemType.Calculator:
                        MenuPages.Add(id, new NavigationPage(new Configuration.CalculatorPage()));
                        break;
                    case (int)MenuItemType.ConfigurationList:
                        MenuPages.Add(id, new NavigationPage(new Configuration.ConfigListPage()));
                        break;
                    case (int)MenuItemType.CriticalConsiderations:
                        MenuPages.Add(id, new NavigationPage(new CriticalConsiderations.CriticalConsiderationsPage()));
                        break;
                    case (int)MenuItemType.EquipmentDescription:
                        MenuPages.Add(id, new NavigationPage(new EquipmentDescription.EquipmentDescriptionPage()));
                        break;
                    case (int)MenuItemType.Erect:
                        MenuPages.Add(id, new NavigationPage(new Procedures.Erect.ErectPage()));
                        break;
                    case (int)MenuItemType.Strike:
                        MenuPages.Add(id, new NavigationPage(new Procedures.Strike.StrikePage()));
                        break;
                    case (int)MenuItemType.BecketLacing:
                        MenuPages.Add(id, new NavigationPage(new Procedures.Erect.BecketLacingPage()));
                        break;
                    case (int)MenuItemType.Maintenance:
                        MenuPages.Add(id, new NavigationPage(new Maintenance.MaintenancePage()));
                        break;
                    case (int)MenuItemType.References:
                        MenuPages.Add(id, new NavigationPage(new References.ReferencesPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }

        void OnULCANSBtn_Clicked(object sender, EventArgs e)
        {
            HomePage destination = new HomePage();
            ((MasterDetailPage)Application.Current.MainPage).Detail.Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }
    }
}