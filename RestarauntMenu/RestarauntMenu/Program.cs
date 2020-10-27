using System;
using System.Collections.Generic;

namespace RestarauntMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem turkey = new MenuItem("Turkey", 2.50, "turkey",  "main course", false);
            MenuItem blt = new MenuItem("BLT", 3.50, "Bacon, lettus, tomato", "main course", false);
            MenuItem bananaSplit = new MenuItem("Banana Split", 65.50, "hotfudge, banana, vanilla icecream, chocolate icecream, strawberry ice cream, peanuts, whipcream", "Dessert", true);
            MenuItem turkey2 = new MenuItem("Turkey", 2.50, "turkey", "main course", false);

            List<MenuItem> myMenu = new List<MenuItem>();         
            Menu final = new Menu(myMenu, DateTime.Now);
            final.AddItem(turkey);
            final.AddItem(blt);
            final.AddItem(bananaSplit);

            final.MenuPrint();
            final.ItemPrint(turkey);
            final.LastUpdated();
            

            for (int i= 0; i < final.MenuItems.Count; i++)
            {
                if (final.MenuItems[i].Equals(turkey2))
                {
                    Console.WriteLine(final.MenuItems[0].Name +
                       " is the same as " + turkey2.Name);
                }
            }
        }   
    }
}
