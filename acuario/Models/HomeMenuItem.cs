using System;
using System.Collections.Generic;
using System.Text;

namespace acuario.Models
{
    public enum MenuItemType
    {
        Collection,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
