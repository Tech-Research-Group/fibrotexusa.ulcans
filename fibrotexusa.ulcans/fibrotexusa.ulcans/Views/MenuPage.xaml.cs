using fibrotexusa.ulcans.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fibrotexusa.ulcans.Views
{
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        private readonly List<HomeMenuItem> menuItems;  // readonly added
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem { Id = MenuItemType.Home, Title="Home", ImageSource="Button_Home_240x240" },
                new HomeMenuItem { Id = MenuItemType.Configuration, Title="Typical Configurations", ImageSource="Button_TypicalConfig_120x120" },
                new HomeMenuItem { Id = MenuItemType.Calculator, Title="Configuration Calculator", ImageSource="Button_Calculator_120x120" },
                new HomeMenuItem { Id = MenuItemType.ConfigurationList, Title="Configuration List", ImageSource="Button_Configuration_240x240" },
                new HomeMenuItem { Id = MenuItemType.CriticalConsiderations, Title="Critical Considerations", ImageSource="Button_CamoBasics_240x240" },
                new HomeMenuItem { Id = MenuItemType.EquipmentDescription, Title="Equipment Description", ImageSource="Button_EqDesc_240x240" },
                new HomeMenuItem { Id = MenuItemType.Erect, Title="Erect", ImageSource="Button_SetUp_240x240" },
                new HomeMenuItem { Id = MenuItemType.Strike, Title="Strike", ImageSource="Button_TearDown_240x240" },
                new HomeMenuItem { Id = MenuItemType.BecketLacing, Title="Becket Lacing", ImageSource="Button_Lacing_240x240" },
                new HomeMenuItem { Id = MenuItemType.Maintenance, Title="Maintenance", ImageSource="Button_Maintenance_240x240" },
                new HomeMenuItem { Id = MenuItemType.References, Title="References", ImageSource="Button_References_240x240" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}