using System;
using RPGEngine.Item;

namespace RPGEngine
{
    public class Inventory
    {
        public Inventory()
        {
            MaxSize = DefaultMaxSize;
            InventoryItems = new List<BaseItem> {};
        }
        public Inventory(int? size, bool allowOverflow)
        {
            if (size is null) {
                MaxSize = DefaultMaxSize;
            } else {
                MaxSize = (int)size;
            }
            AllowOverflow = allowOverflow;
            InventoryItems = new List<BaseItem> {};
        }
        // Not static, to support character false, and merchant true
        public bool AllowOverflow { get; set; }

        // Deafult for creating new characters, versus MaxSize (if the player buys a bigger pack)
        public static int DefaultMaxSize { get; set; } = 20;
        public int MaxSize { get; set; }
        public int OccupiedSize { get
            {
                int calcOccupied = 0;
                InventoryItems.ForEach(delegate(BaseItem item) {
                    calcOccupied += item.Size;
                });
                return calcOccupied;
            }
        }

        // Contains anything that extends BaseItem
        public List<BaseItem> InventoryItems { get; set; }

        // I'm under the impression that getting something from InventoryItems
        // will require some sort of validation or limiting in the future,
        // so we're leaving this here for the time being
        public List<BaseItem> getInventory()
        {
            return InventoryItems;
        }

        public bool addToInventory(BaseItem newItem) {
            // If the item is too big, don't add it
            if (AllowOverflow == false && OccupiedSize + newItem.Size > MaxSize)
            {
                return false;
            } else {
                InventoryItems.Add(newItem);
                return true;
            }
        }

        public bool RemoveFromInventory(BaseItem oldItem) {
            return InventoryItems.Remove(oldItem);
        }


    }
}

