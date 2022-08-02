using System;
namespace RPGEngine.Item
{
    public class BaseItem
    {
        public BaseItem() {
            Name = "";
            Description = "";
            Type = "";
            ItemCategory = "";
            Rarity = "";
            Size = 0;
            Price = 0.0f;
        }
        public BaseItem(string name, int size, float price) {
            Name = name;
            Description = "";
            Type = "";
            ItemCategory = "";
            Rarity = "";
            Size = size;
            Price = price;

        }
        public BaseItem(string name, string type, string itemCategory, string rarity, int size, float price){
            Name = name;
            Description = "";
            Type = type;
            ItemCategory = itemCategory;
            Rarity = rarity;
            Size = size;
            Price = price;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string ItemCategory { get; set; }
        public string Rarity { get; set; }
        public int Size { get; set; }
        public float Price { get; set; }

        private enum ItemTypes
        {
            Equipable,
            Consumable,
            Enchantment,
            None
        }

        private enum ItemCategories
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Purple,
            Black,
            White
        }

        private enum ItemRarities
        {
            Worthless,
            VeryCommon,
            Common,
            Uncommon,
            Rare,
            VeryRare,
            ExtremelyRare,
            Legendary,
            Impossible
        }
    }
}

