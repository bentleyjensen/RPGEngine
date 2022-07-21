using System;
namespace RPGEngine
{
    public class Item : BaseItem
    {
        public Item(string description, string itemType, string itemCategory, int itemSize, )
        {
        }

        public void addEffect(Effect itemEffect)
        {
            BaseItem.Effects.Append(itemEffect);
        }

        public void addEffects(Effect[] itemEffects)
        {
            Effects.Append(itemEffects);
        }
    }
}

