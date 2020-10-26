using System;
using System.Collections.Generic;

namespace RestarauntMenu
{
    public class Menu
    {
        public DateTime date1 { get; set; }
        public List<MenuItem> MenuItems;
        public DateTime date2 = DateTime.Now;
        public Menu(List<MenuItem> menuItems)
        {
            MenuItems = menuItems;
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
            this.date1 = DateTime.Now;
            return "The menu was last updated " + this.date1;
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
