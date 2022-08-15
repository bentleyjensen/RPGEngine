using System;
using RPGEngine.Item;

namespace RPGEngine
{
    public class Character : BaseCharacter
    {
        public Character(string name, int startStat) : base(startStat)
        {
            Name = name;
            Inventory = new Inventory(30, false);
            EquippedItems = new List<EquipableItem> { };
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public Inventory Inventory { get; set; }
        public List<EquipableItem> EquippedItems { get; set; }

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

        /// <summary>
        /// Equip an item, applying the effects to the character
        /// </summary>
        /// <param name="item">Item to equip</param>
        /// <param name="equipSlot">Slot the item is equipped in</param>
        /// <returns>True if the item was successfully equipped, false otherwise</returns>
        public bool Equip(EquipableItem item, string equipSlot) {
            // TODO: implement exceptions
            // Check if item has the equipslot listed
            if (false)
                throw new Exception($"Item cannot be equiped in the {equipSlot} slot");
            // Check equiped items to see if the slot is already taken
            if (false)
                throw new Exception($"There is already an item equiped in the {equipSlot} slot");
            // Check that the item is in the inventory
            if (false)
                throw new Exception($"{item.Name} is not in the inventory");

            List<string> affectedStats = new List<string> { };

            // Remove from Inventory
            Inventory.Remove(item);
            // Add to EquipedItems
            EquippedItems.Add(item);
            // Add status effects/enchantments to stats
            foreach (Effect effect in item.EquipEffects)
            {
                Statistics.StatusEffects.Add(effect);
                affectedStats.Add(effect.Statistic);
            }

            foreach (Effect effect in item.Enchantments)
            {
                Statistics.StatusEffects.Add(effect);
                affectedStats.Append(effect.Statistic);
            }

            // Recalculate stats so the working stats are accurate
            foreach(string stat in affectedStats)
            {
                Statistics.RecalulateStats(stat);
            }
            return true;
        }

        /// <summary>
        /// Remove an actively equipped item
        /// </summary>
        /// <param name="item"></param>
        public void Unequip(EquipableItem item) {
            // Remove from EquipedItems
            // Add to Inventory
            // Remove status effects/enchantments to stats
        }

        /// <summary>
        /// Apply the effects of ConsumableItem to oneself
        /// </summary>
        /// <param name="item">Item to consume</param>
        public void Consume(ConsumableItem item) {
            Console.WriteLine(item);
            Console.WriteLine(item.Description);
            return;
        }

        /// <summary>
        /// Apply the effects of ConsumableItem to a target
        /// </summary>
        /// <param name="item">The item to throw</param>
        /// <param name="target">A BaseCharacter to apply the effects to</param>
        // What are we throwing, and who are we throwing it at?
        public void Throw(ConsumableItem item, BaseCharacter target) {
            return;
        }
        public void OnAttack() { }
        public void OnDefend() { }
        public void OnDeath() { }
        public void OnSpawn() { }
    }
}