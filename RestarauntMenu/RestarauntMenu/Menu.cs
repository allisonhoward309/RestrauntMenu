using System;
using System.Collections.Generic;

namespace RestarauntMenu
{
    public class Menu
    {
        public DateTime Date1 { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public Menu(List<MenuItem> menuItems, DateTime date1)
        {
            MenuItems = menuItems;
            Date1 = date1;
        }

        public List<MenuItem> AddItem(MenuItem item)
        {
            MenuItems.Add(item);
            return MenuItems;
        }

        public List<MenuItem> RemoveItem(MenuItem item)
        {
            MenuItems.Remove(item);
            return MenuItems;
        }
        public void MenuPrint()
        {
            foreach (MenuItem item in this.MenuItems)
            {
                Console.WriteLine(item.Name + ": $" + item.Price);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.New());
                Console.WriteLine();
            }
        }
        public void LastUpdated ()
        {
            Console.WriteLine( "The menu was last updated " + Date1);
        }

        public void ItemPrint (MenuItem item)
        {
            Console.WriteLine(item.Name + ": $" + item.Price);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Category);
            Console.WriteLine(item.New());
            Console.WriteLine();

        }

    }
}
