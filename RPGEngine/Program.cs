using System;
using RPGEngine.Item;

namespace RPGEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Character Bentley = new Character("Bentley", 1);
            Bentley.Inventory.addToInventory(Items.Potions.BigPotion);

            List<BaseItem> bInventory = Bentley.Inventory.getInventory();

            Console.WriteLine(bInventory[0].Description);
            Console.WriteLine(Items.Potions.HealingPotion1.Description);
            Console.WriteLine("PLBTH");


            
        }
    }
}