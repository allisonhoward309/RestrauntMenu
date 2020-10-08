using Microsoft.VisualBasic.CompilerServices;
using System;

namespace RestarauntMenu
{
    public class MenuItem
    {
        private string name;
        private double price;
        private string description;
        private string category;
        private Boolean status; 
    public MenuItem (string name, double price, string description, string category, Boolean status)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.Status = status;

        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
        public bool Status { get => status; set => status = value; }
    }
}