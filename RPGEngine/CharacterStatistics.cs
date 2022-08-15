using System;
using System.Reflection;
using System.Linq;

namespace RPGEngine
{
    public class CharacterStatistics
    {
        public CharacterStatistics()
        {
            BaseStats = new BaseStatistics();
            Stats = new BaseStatistics();
            StatusEffects = new List<Effect> { };
        }

        public CharacterStatistics(int DefaultNum)
        {
            BaseStats = new BaseStatistics(DefaultNum);
            Stats = new BaseStatistics(DefaultNum);
            StatusEffects = new List<Effect> { };
        }

        /// <summary>
        /// BaseStats determines the characters statistics with no status effects applied
        /// </summary>
        public BaseStatistics BaseStats { get; set; }

        /// <summary>
        /// Stats is the "working statistic," or the effective stats after all status effects are applied
        /// </summary>
        public BaseStatistics Stats { get; set; }

        /// <summary>
        /// The status effects being applied to the character
        /// </summary>
        public List<Effect> StatusEffects { get; set; }

        /// <summary>
        /// Add an additional status effect to the character
        /// </summary>
        /// <param name="effect">The status effect to add</param>
        public void AddStatusEffect(Effect effect) {
            StatusEffects.Add(effect);
            RecalulateStats(effect.Statistic);
        }

        /// <summary>
        /// Iterate through all current status effects and determine actual statistics
        /// </summary>
        public void RecalulateStats() {
            PropertyInfo[] properties = typeof(BaseStatistics).GetProperties();
            foreach(PropertyInfo prop in properties)
            {
                // Convert prop name to a string to compare to the effect statistic
                string propName = prop.ToString().Split(' ')[1];

                // Obtain all effects listing the current property
                var propEffects = from effect in StatusEffects
                                  where effect.Statistic == propName
                                  select effect;

                // Init as base number
                prop.SetValue(Stats, prop.GetValue(BaseStats));

                // Add each effect to the current value of the stat
                foreach(Effect effect in propEffects)
                {
                    int currentValue = (int) prop.GetValue(BaseStats);
                    prop.SetValue(Stats, currentValue + effect.Amount);
                }
            }
        }
        /// <summary>
        /// Recalculate a single statistic
        /// </summary>
        /// <param name="statistic">A string representing the statistic to recalculate</param>
        public void RecalulateStats(string statistic) {
            PropertyInfo[] properties = typeof(BaseStatistics).GetProperties();

            // Returns an iEnumberable<T>, but should only have one in it
            var selectProperties = from prop in properties
                        where prop.ToString().Split(' ')[1] == statistic
                        select prop;

            // Since it's an iEnumerable, we have to iterate, even though we only expect one
            foreach (var property in selectProperties)
            {
                // Init property to BaseStat value
                property.SetValue(Stats, property.GetValue(BaseStats));

                var propName = property.ToString().Split(' ')[1];

                var propEffects = from effect in StatusEffects
                                  where effect.Statistic == propName
                                  select effect;

                foreach (Effect effect in propEffects)
                {
                    int currentValue = (int) property.GetValue(Stats);
                    property.SetValue(Stats, currentValue + effect.Amount);
                }
            }
        }
    }
}

