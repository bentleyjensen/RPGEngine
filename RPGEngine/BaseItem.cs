using System;
namespace RPGEngine
{
    public class BaseItem
    {
        public BaseItem()
        {
            Effects = new Effect[] { };
        }

        public string Description { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string ItemCategory { get; set; }

        public Effect[] Effects { get; set; }

        public float Price { get; set; }
        public Enum EquipableSlots { get; set; }
        public bool Consumable { get; set; }

        private enum ItemTypes
        {
        Potion,
        Weapon,
        Tool,
        Food,
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

