using System;
using System.Text;

namespace RPGEngine.Item
{
    public class EquipableItem : BaseItem
    {

        public EquipableItem()
        {
            EquipableSlots = new List<string> { };
            EquipEffects = new List<Effect> { };
            Enchantments = new List<Effect> { };
        }

        public List<string> EquipableSlots { get; set; }
        public List<Effect> EquipEffects { get; set; }
        public List<Effect> Enchantments { get; set; }

        new public string Description
        {
            get
            {
                // String builder to hold multi-line description
                StringBuilder desc = new StringBuilder();

                // A function to iterate through each effect
                void descriptionMaker(Effect effect)
                {
                    // Mark positive and negative values
                    string polarity = (effect.Amount < 0) ? "" : "+";
                    // If it's turn-based, list turns
                    string turnCount = (effect.isTurnBased) ? $" for {effect.TurnsToExpire} turns" : "";
                    // Append description
                    desc.AppendLine($"{polarity}{effect.Amount} {effect.Statistic}{turnCount}");
                };

                foreach(Effect effect in EquipEffects) {
                    descriptionMaker(effect);
                }

                foreach(Effect effect in Enchantments) {
                    descriptionMaker(effect);
                }

                // Enchantments

                // Consumable items specifically don't make sense without an effect, but return something anyway
                return (desc.Length > 0) ? desc.ToString() : "No Effect";
            }
        }
    }
}

