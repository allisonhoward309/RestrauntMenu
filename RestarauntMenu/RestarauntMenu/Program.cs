using System;
using System.Collections.Generic;

namespace RestarauntMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Turkey = new MenuItem("Turkey", 2.50, "turkey",  "main course", false);
            MenuItem BLT = new MenuItem("BLT", 3.50, "Bacon, lettus, tomato", "main course", false);
            MenuItem bananaSplit = new MenuItem("Banana Split", 65.50, "hotfudge, banana, vanilla icecream, chocolate icecream, strawberry ice cream, peanuts, whipcream", "Dessert", true);
            List<MenuItem> MenuList = new List<MenuItem> {Turkey, BLT, bananaSplit};
            Menu final = new Menu(MenuList);
            foreach (MenuItem item in MenuList)
            {
                Console.WriteLine(item.Name + ": $" + item.Price);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Category);
                if(item.Status == true)
                {
                    Console.WriteLine("New!");
                }
                Console.WriteLine();

            }
            Console.WriteLine(final.date1);
        }
    }
}
