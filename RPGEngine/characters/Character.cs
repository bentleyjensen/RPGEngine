using System;
using RPGEngine.Item;

namespace RPGEngine
{
    public class Character : BaseCharacter
    {
        public Character(string name, int startStat) : base(startStat)
        {
            Name = name;
            Inventory = new Inventory(30, true);
            EquipedItems = new List<EquipableItem> { };
            StatisticEffects = new List<Effect> { };
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public Inventory Inventory { get; set; }
        public List<EquipableItem> EquipedItems { get; set; }
        public List<Effect> StatisticEffects { get; set; }

        public string[] EquipSlots =
        {
            "Head",
            "Upper Body",
            "Lower Body",
            "Right Hand",
            "Left Hand",
            "Feet",
            "Bracelet",
            "Necklace",
            "Earring",  
            "Ring1",
            "Ring2",
            "Ring3",
            "Ring4",
            "Ring5",
            "Pet1",
            "Pet2",
        };

        public void Equip() { 
            // Remove from Inventory
            // Add to EquipedItems
        }
        public void Unequip() {
            // Remove from EquipedItems
            // Add to Inventory
        }
        public void OnAttack() { }
        public void OnDefend() { }
        public void OnDeath() { }
        public void OnSpawn() { }
    }
}