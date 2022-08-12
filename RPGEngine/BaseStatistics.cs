using System;
namespace RPGEngine
{
    public class BaseStatistics
    {
        public BaseStatistics() {
            SoloEffects = new Effect[] { };
            PartyEffects = new Effect[] { };
        }
        public BaseStatistics(int defaultNum)
        {
            SoloEffects = new Effect[] { };
            PartyEffects = new Effect[] { };

            MaxHealth = defaultNum;
            MaxMana = defaultNum;
            Health = defaultNum;
            Mana = defaultNum;

            Strength = defaultNum;
            Defense = defaultNum;
            Dexterity = defaultNum;
            Intelligence = defaultNum;
            Wisdom = defaultNum;
            Charisma = defaultNum;
            Luck = defaultNum;
        }

        public int MaxHealth { get; set; } = 100;
        public int Health { get; set; } = 100;
        public int HealthRecovery { get; set; } = 0;
        public int HealthResist { get; set; } = 0;

        public int MaxMana { get; set; } = 100;
        public int Mana { get; set; } = 100;
        public int ManaRecovery { get; set; } = 0;
        public int ManaResist { get; set; } = 0;

        public int MaxHunger { get; set; } = 100;
        public int Hunger { get; set; } = 100;
        public int HungerRate { get; set; } = 5;

        public Effect[] SoloEffects { get; set; }
        public Effect[] PartyEffects { get; set; }

        public int Strength { get; set; } = 1; // Power/Damage/max carry weight
        public int Defense { get; set; } = 1; // Resiliency: decreases damage, recovery
        public int Dexterity { get; set; } = 1; // Agility: dodge chance, movement speed, attack speed
        public int Intelligence { get; set; } = 1; // Magic skill, points when leveling up
        public int Wisdom { get; set; } = 1; // Party loyalty, Magic skill (casting...?), secret revelation?
        public int Charisma { get; set; } = 1; // Social: trading prices, NPC niceness/honesty
        public int Luck { get; set; } = 1; // Critical hit chance, drop item rarity chance, etc.

        public int FireResist { get; set; } = 0;
        public int WaterResist { get; set; } = 0;
        public int MagicResist { get; set; } = 0;
        public int PoisonResist { get; set; } = 0;
        public int HungerResist { get; set; } = 0;
    }
}

