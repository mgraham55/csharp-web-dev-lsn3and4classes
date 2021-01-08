using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List <MenuItem> Item { get; set; }
        public int Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string RestaurantName { get; set; }
        public string Name { get; set; }
        public void AddItem(MenuItem item)
        {
            if (this.Item == null)
            {
                this.Item = new List<MenuItem>();
            }
            this.Item.Add(item);
            this.LastUpdated = DateTime.Now;
        }
        public bool RemoveItem(MenuItem item)
        {
            if(this.Item == null)
            {
                this.Item = new List<MenuItem>();
                return false;
            }
            
            bool removed = this.Item.Remove(item);
            if (removed)
            {
                this.LastUpdated = DateTime.Now;
            }
            return removed;
        }

        public Menu()
        {
        }

        public Menu(int id, List<MenuItem> items, DateTime lastUpdated,
            string name, string restaurantName)
        {
            this.Id = id;
            this.Item = items;
            this.LastUpdated = lastUpdated;
            this.Name = name;
            this.RestaurantName = restaurantName;
        }

        // Constructor(...args) : this(...args, extraValues)
        public Menu(int _id, string _name, string _restaurantName) : 
            this(_id, 
                new List<MenuItem>(), 
                DateTime.Now, 
                _name, 
                _restaurantName)
        { }
       
    }
}
