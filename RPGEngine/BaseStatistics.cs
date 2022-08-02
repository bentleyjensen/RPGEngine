using System;
namespace RPGEngine
{
    public class BaseStatistics
    {
        public BaseStatistics(int defaultNum)
        {
            SoloEffects = new Effect[] { };
            PartyEffects = new Effect[] { };

            HealthPoints = defaultNum;
            ManaPoints = defaultNum;
            CurrentHealth = defaultNum;
            CurrentMana = defaultNum;

            Strength = 1;
            Defense = 1;
            Dexterity = 1;
            Intelligence = 1;
            Wisdom = 1;
            Charisma = 1;
            Luck = 1;


        }

        public int HealthPoints { get; set; }
        public int CurrentHealth { get; set; }
        public int HealthRecovery { get; set; }
        public int HealthResist { get; set; }

        public int ManaPoints { get; set; }
        public int CurrentMana { get; set; }
        public int ManaRecovery { get; set; }
        public int ManaResist { get; set; }

        public int Hunger { get; set; }
        public Effect[] SoloEffects { get; set; }
        public Effect[] PartyEffects { get; set; }

        public int Strength { get; set; } // Power/Damage/max carry weight
        public int Defense { get; set; } // Resiliency: decreases damage, recovery
        public int Dexterity { get; set; } // Agility: dodge chance, movement speed, attack speed
        public int Intelligence { get; set; } // Magic skill, points when leveling up
        public int Wisdom { get; set; } // Party loyalty, Magic skill (casting...?)
        public int Charisma { get; set; } // Social: trading prices, NPC niceness/honesty
        public int Luck { get; set; } // Critical hit chance, drop item rarity chance, etc.

        public int FireResist { get; set; }
        public int WaterResist { get; set; }
        public int MagicResist { get; set; }
        public int PoisonResist { get; set; }
        public int HungerResist { get; set; }
    }
}

