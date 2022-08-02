using System;
using RPGEngine.Item;
using RPGEngine;

namespace RPGEngine.Items
{
    public class Potions
    {
        public static ConsumableItem BigPotion = new ConsumableItem
        {
            Name = "Healing Potion",
            Type = "Consumable",
            ItemCategory = "Red",
            Rarity = "Common",
            Price = 3,
            ConsumeEffects = new List<Effect> {
                Effects.Health1,
                Effects.Mana1,
                Effects.Charisma1,
                Effects.Consitution1
            }
        };
        public static ConsumableItem HealingPotion1 = new ConsumableItem
        {
            Name = "Healing Potion",
            Type = "Consumable",
            ItemCategory = "Red",
            Rarity = "Common",
            Price = 3,
            ConsumeEffects = new List<Effect> {
                Effects.Health1
            }
        };
        public static ConsumableItem HealingPotion2 = new ConsumableItem
        {
            Name = "Healing Potion",
            Type = "Consumable",
            ItemCategory = "Red",
            Rarity = "Common",
            Price = 5,
            ConsumeEffects = new List<Effect> {
                Effects.Health2
            }
        };
    };
}
