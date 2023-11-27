using System;
using System.Collections.Generic;
using System.Text;

namespace fibrotexusa.ulcans.Models
{
    public enum MenuItemType
    {
        Home,
        Configuration,
        Calculator,
        ConfigurationList,
        CriticalConsiderations,
        EquipmentDescription,
        //Procedures,
        Erect,
        Strike,
        BecketLacing,
        Maintenance,
        References
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
        public string ImageSource { get; set; }
    }
}
