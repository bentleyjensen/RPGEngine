using System;
namespace RPGEngine
{
    public class CharacterStatistics : BaseStatistics
    {
        public CharacterStatistics()
        {
            SoloEffects = new Effect[] { };
            PartyEffects = new Effect[] { };
        }

        //public int HealthPoints { get; set; }
        //public int CurrentHealth { get; set; }
        //public int HealthRecovery { get; set; }
        //public int HealthResist { get; set; }

        //public int ManaPoints { get; set; }
        //public int CurrentMana { get; set; }
        //public int ManaRecovery { get; set; }
        //public int ManaResist { get; set; }

        //public int Hunger { get; set; }
        //public Effect[] SoloEffects { get; set; }
        //public Effect[] PartyEffects { get; set; }
    }
}

