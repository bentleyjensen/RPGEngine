using System;
namespace RPGEngine.Item
{
    public class EquipableItem : BaseItem
    {
        public List<string> EquipableSlots { get; set; }

        public EquipableItem(List<string> equipableSlots)
        {
            EquipableSlots = equipableSlots;
        }


        
    }
}

