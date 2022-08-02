using System;

namespace RPGEngine
{
    public class Effect
    {
        public int Amount { get; set; }
        public string Statistic { get; set; }
        public bool isPermanent { get; set; }
        public bool isTurnBased { get; set; }
        public int? TurnsToExpire { get; set; }

        public Effect(int amount, string statistic, bool permanent, bool turnBased, int? turnsToExpire)
        {
            Amount = amount;
            Statistic = statistic;
            isPermanent = permanent;
            isTurnBased = turnBased;
            TurnsToExpire = turnsToExpire;
        }

        public enum StatisticEffects
        {
            Health,
            Mana,
            Hunger,

            HealingRate,
            ManaRate,

            Strength,
            Consitution,
            Dexterity,
            Intelligence,
            Wisdom,
            Charisma,
            Luck,
        } 
    }
}

