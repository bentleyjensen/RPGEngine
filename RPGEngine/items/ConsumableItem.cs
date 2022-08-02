using System;
using System.Text;

namespace RPGEngine.Item
{
    public class ConsumableItem : BaseItem
    {
        public ConsumableItem()
        {
            ConsumeEffects = new List<Effect> { };
        }
        new public string Description { get
            {
                // String builder to hold multi-line description
                StringBuilder desc = new StringBuilder();

                // Iterate through all effects and add their small description to the larger
                ConsumeEffects.ForEach(delegate(Effect effect)
                {
                    // Mark positive and negative values
                    string polarity = (effect.Amount < 0) ? "-" : "+";
                    // If it's turn-based, list turns
                    string turnCount = (effect.isTurnBased) ? $" for {effect.TurnsToExpire} turns": "";
                    // Append description
                    desc.AppendLine($"{polarity}{effect.Amount} {effect.Statistic}{turnCount}");
                });

                // Consumable items specifically don't make sense without an effect, but return something anyway
                return (desc.Length > 0) ? desc.ToString() : "No Effect";
            }
        }

        public List<Effect> ConsumeEffects { get; set; }

        public void AddConsumeEffect(Effect effect)
        {
            ConsumeEffects.Add(effect);
        }

        public void AddConsumeEffects(List<Effect> effect)
        {
            ConsumeEffects.Concat(effect);
        }
    }
}

