using System;
namespace RPGEngine
{
    public class Effect
    {
        public Effect()
        {
        }

        public enum Debuffs
        {
            Bleeding, // Lose health, healed by {some item type}
            Poisoned, // Lose health, healed by {some item type}
            Burning, // Lose health, healed by {some item type}
            Cursed, // TODO something bad and magic-based
            Slowed, // Decreased speed // Not so quick now, are ya?
            Weakened, // Strength decreased
            ArmorBroke, // Defense decreased
            WeaponBroke, // Damage decreased
            FrostBite, // Speed and strength decreased
            Electrified, // Lose health ( and speed decrease?)
            Hungry, // Lose health, healed by food items
            Stunned, // Cannot attack, cannot be healed
            Overflowed, // Backpack is over limit
            Drunk, // TODO various random stats lowered

        }

        public enum Buffs
        {
            SharpShooter, // noConsumeAmmo (physical ranged only)
            Killer, // increase enemy spawn rate
            Calm, // Decrease enemy spawn rate
            Endurance, // Increased running time (Needs a setting for infinite, can't think of what)
            lightweight, // Increased Speed
            fishLungs, // Breathe underwater
            invisible, // invisible to enemies
            
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

        public enum 
    }
}

