using System;
namespace fibrotexusa.ulcans.Models
{
    public class Platform
    {
        public string Name { get; set; }
        public string Configuration { get; set; }
        public string ImageSource { get; set; }
        public string ShapeSource { get; set; }

        public Platform()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
