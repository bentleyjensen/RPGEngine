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
            AllowOverflow = false;
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

        /// <summary>
        /// The default inventory size when none is provided
        /// </summary>
        public static int DefaultMaxSize { get; set; } = 20;

        /// <summary>
        /// <c>MaxSize</c> is the size of the inventory that is enforced
        /// </summary>
        public int MaxSize { get; set; }

        /// <summary>
        /// The amount of inventory currently being used by the items it contains
        /// </summary>
        public int OccupiedSize { get; private set;}

        /// <summary>
        /// <c>AllowOverflow</c> determines whether items can be added if the total size would be greater than the MaxSize
        /// </summary>
        // Not static, to support character false, and merchant true
        public bool AllowOverflow { get; set; }

        // Contains anything that extends BaseItem
        private List<BaseItem> InventoryItems { get; set; }

        /// <summary>
        /// Retrieve the full list of items in the inventory
        /// </summary>
        /// <returns>List&lt;BaseItem&gt; with current inventory items</returns>
        public List<BaseItem> Get()
        {
            return InventoryItems;
        }

        /// <summary>
        /// Add a single item to the inventory. Accepts any type that extends <c>BaseItem</c>.
        /// </summary>
        /// <param name="newItem">Item to add to the inventory</param>
        /// <returns>False if the item could not be added, true otherwise</returns>
        public bool Add(BaseItem newItem) {
            // If the item is too big, don't add it
            if (AllowOverflow == false && OccupiedSize + newItem.Size > MaxSize)
            {
                return false;
            } else {
                OccupiedSize += newItem.Size;
                InventoryItems.Add(newItem);
                return true;
            }
        }

        /// <summary>
        /// Remove a single item from the inventory. Accepts any type that extends <c>BaseItem</c>.
        /// </summary>
        /// <param name="oldItem">Item to remove from the inventory</param>
        /// <returns>False if the item could not be removed, true otherwise</returns>
        public bool Remove(BaseItem oldItem) {
            bool removed = InventoryItems.Remove(oldItem);
            
            if (removed)
            {
                OccupiedSize -= oldItem.Size;
                return true;
            } else {
                return false;
            }
        }


    }
}

