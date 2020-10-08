using System;
using System.Collections.Generic;

namespace RestarauntMenu
{
    public class Menu
    {
        public DateTime date1 = DateTime.Now;
        public List<MenuItem> MenuItems;
        public Menu(List<MenuItem> MenuItems)
        {
            this.MenuItems = MenuItems;
        }

    }
}