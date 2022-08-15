using System;
using RPGEngine.Item;

namespace RPGEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Character Bentley = new Character("Bentley", 1);
            Bentley.Inventory.Add(Items.Potions.BigPotion);
            Bentley.Inventory.Add(Items.Armor.CopperHelmet);

            System.Console.WriteLine(((EquipableItem) Bentley.Inventory.Get()[1]).Description);
            System.Console.WriteLine("Starting Defense: {0}", Bentley.Statistics.Stats.Defense);
            Bentley.Equip(Items.Armor.CopperHelmet, "Head");
            foreach(Effect effect in Bentley.Statistics.StatusEffects)
            {
                System.Console.WriteLine(effect);
            }
            System.Console.WriteLine("Ending Defense: {0}", Bentley.Statistics.Stats.Defense);

            
        }
    }
}