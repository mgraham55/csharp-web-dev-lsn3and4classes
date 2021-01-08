using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsNewItem { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Category { get; set; }

        public MenuItem()
        {
        }

        public MenuItem(int id, double price, string name, string description, bool isNew, DateTime lastUpdate, string category)
        {
            this.Id = id;
            this.Price = price;
            this.Name = name;
            this.Description = description;
            this.IsNewItem = isNew;
            this.LastUpdated = lastUpdate;
            this.Category = category;
        }

        public MenuItem(int id, double price, string name, string description, string category)
        {
            this.Id = id;
            this.Price = price;
            this.Name = name;
            this.Description = description;
            this.Category = category;

            this.IsNewItem = true;
            this.LastUpdated = DateTime.Now;
        }

    }
}
