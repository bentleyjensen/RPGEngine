using System;
using RPGEngine.Item;
using RPGEngine;

namespace RPGEngine.Items
{
    public class Potions
    {
        public static ConsumableItem BigPotion = new ConsumableItem
        {
            Name = "Big Potion",
            Type = "Consumable",
            ItemCategory = "Purple",
            Rarity = "ExtremelyRare",
            Price = 150,
            ConsumeEffects = new List<Effect> {
                Effects.Health5,
                Effects.Mana5
            }
        };
        public static ConsumableItem HealingPotion1 = new ConsumableItem
        {
            Name = "Small Healing Potion",
            Type = "Consumable",
            ItemCategory = "Red",
            Rarity = "Very Common",
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
        public static ConsumableItem HealingPotion3 = new ConsumableItem
        {
            Name = "Large Healing Potion",
            Type = "Uncommon",
            ItemCategory = "Red",
            Rarity = "Rare",
            Price = 10,
            ConsumeEffects = new List<Effect> {
                Effects.Health3
            }
        };
        public static ConsumableItem HealingPotion4 = new ConsumableItem
        {
            Name = "Extra Large Healing Potion",
            Type = "Consumable",
            ItemCategory = "Red",
            Rarity = "Rare",
            Price = 50,
            ConsumeEffects = new List<Effect> {
                Effects.Health4
            }
        };
        public static ConsumableItem HealingPotion5 = new ConsumableItem
        {
            Name = "Massive Healing Potion",
            Type = "Consumable",
            ItemCategory = "Red",
            Rarity = "VeryRare",
            Price = 100,
            ConsumeEffects = new List<Effect> {
                Effects.Health5
            }
        };

        public static ConsumableItem ManaPotion1 = new ConsumableItem
        {
            Name = "Small Mana Potion",
            Type = "Consumable",
            ItemCategory = "Blue",
            Rarity = "VeryCommon",
            Price = 3,
            ConsumeEffects = new List<Effect>{
                Effects.Mana1
            }
        };

        public static ConsumableItem ManaPotion2 = new ConsumableItem
        {
            Name = "Mana Potion",
            Type = "Consumable",
            ItemCategory = "Blue",
            Rarity = "Common",
            Price = 5,
            ConsumeEffects = new List<Effect>{
                Effects.Mana2
            }
        };

        public static ConsumableItem ManaPotion3 = new ConsumableItem
        {
            Name = "Large Mana Potion",
            Type = "Consumable",
            ItemCategory = "Blue",
            Rarity = "Uncommon",
            Price = 10,
            ConsumeEffects = new List<Effect>{
                Effects.Mana3
            }
        };

        public static ConsumableItem ManaPotion4 = new ConsumableItem
        {
            Name = "Extra Large Mana Potion",
            Type = "Consumable",
            ItemCategory = "Blue",
            Rarity = "Rare",
            Price = 50,
            ConsumeEffects = new List<Effect>{
                Effects.Mana4
            }
        };

        public static ConsumableItem ManaPotion5 = new ConsumableItem
        {
            Name = "Massive Mana Potion",
            Type = "Consumable",
            ItemCategory = "Blue",
            Rarity = "VeryRare",
            Price = 100,
            ConsumeEffects = new List<Effect> {
                Effects.Mana5
            }
        };
    };
    public class Armor
    {
        public static EquipableItem CopperHelmet = new EquipableItem
        {
            Name = "Copper Helmet",
            Type = "Green",
            ItemCategory = "Equipable",
            Rarity = "Common",
            Size = 1,
            Price = 5,
            EquipableSlots = new List<string> { "Head" },
            EquipEffects = new List<Effect>
            {
                new Effect(2, "Defense", false, false, null)
            }
        };

    }

    public class Other
    {

        public static ConsumableItem Beer = new ConsumableItem
        {
            Name = "Beer",
            Type = "Consumable",
            ItemCategory = "Red",
            Rarity = "Common",
            Price = 3,
            ConsumeEffects = new List<Effect> {
                Effects.Health2,
                new Effect(-2, "Intelligence", false, true, 5),
                new Effect(2, "Constitution", false, true, 5)
            }
        };
    }
}
