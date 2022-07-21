using System;
namespace RPGEngine
{
    public class Character : BaseCharacter
    {
        public Character(string name)
        {
            Name = name;
        }

        public string Name = "";
        public string[] EquipSlots =
        {
            "Head",
            "Upper Body",
            "Lower Body",
            "Right Hand",
            "Left Hand",
            "Feet",
            "Bracelet",
            "Necklace",
            "Earring",
            "Ring1",
            "Ring2",
            "Ring3",
            "Ring4",
            "Ring5",
            "Pet1",
            "Pet2",
        };

        public Item[] EquipedItems = { };

        public void OnAttack() { }
        public void OnDefend() { }
        public void OnDeath() { }
        public void OnSpawn() { }
    }
}

