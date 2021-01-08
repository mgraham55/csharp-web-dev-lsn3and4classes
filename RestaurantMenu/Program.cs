using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem ramen = new MenuItem();

            ramen.Id = 01;
            ramen.Price = 3.89;
            ramen.Name = "Ramen";
            ramen.Description = "Easy homemade ramen, with a flavorful broth,  fresh veggies, lots of noodles, and a soft cooked egg with your choice of steak, chicken, pork, or shrimp.";
            ramen.IsNewItem = false;
            ramen.LastUpdated = DateTime.Now;
            ramen.Category = "Noods";

            MenuItem pho = new MenuItem(02, 3.89, "Pho", "A delicious vietnamese soup consisting of savory broth, rice noodles, herbs, with your choice of beef or chicken.", false, DateTime.Now, "Noods");

            MenuItem potStickers = new MenuItem(03, 1.99, "Pot Stickers(3)", "Dumpling filled cabbage and vegetables pan fried and steamednice crispy exterior and a juicy interior. Your choice of vegetable or pork.", "Appetizer");

            Menu newItems = new Menu(01, "New Items", "Send Noods");
            newItems.AddItem(ramen);
            newItems.AddItem(pho);
            newItems.AddItem(potStickers);

            Console.WriteLine($"{newItems.Name}, {newItems.Item.Count} items");

            newItems.RemoveItem(pho);

            Console.WriteLine($"{newItems.Name}, {newItems.Item.Count} items");
        }
    }
}
