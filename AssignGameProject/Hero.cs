using System;
using System.Collections.Generic;

namespace AssignGameProject
{
    public abstract class Hero
    {
        // properties
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public HeroAttribute BaseAttributes { get; set; }
        public Dictionary<SlotEnumsTypes, Item> Equipment { get; set; }
        public List<WeaponTypes> ValidWeaponTypes { get; set; }
        public List<ArmorTypes> ValidArmorTypes { get; set; }

        // Constructor
        public Hero(string name)
        {
            Name = name;
            BaseAttributes = new HeroAttribute(1, 1, 1);
            Equipment = new Dictionary<SlotEnumsTypes, Item>
            {
                { SlotEnumsTypes.Weapon, null },
                { SlotEnumsTypes.Body, null },
                { SlotEnumsTypes.Head, null },
                { SlotEnumsTypes.Legs, null }
            };

            ValidWeaponTypes = new List<WeaponTypes>();
            ValidArmorTypes = new List<ArmorTypes>();
        }

        public abstract void LevelUp();

        public void Equip(Item item)
        {
            if (item is Weapon weapon)
            {
                if (!ValidWeaponTypes.Contains(weapon.WeaponType))
               
                    Console.WriteLine("Cannot equip this weapon.");
                
                if (weapon.RequiredLevel > Level)
                
                    Console.WriteLine("Weapon equip.");
                
                Equipment[SlotEnumsTypes.Weapon] = weapon;
            }
            else if (item is Armor armor)
            {
                
                if (!ValidArmorTypes.Contains(armor.ArmorType))
                {
                    throw new InvalidArmorException($"{Name} cannot equip this armor type.");
                }

                
                if (armor.RequiredLevel > Level)
                {
                    throw new InvalidArmorException($"{Name} does not meet the required level for this armor.");
                }

                Equipment[armor.Slot] = armor;
            }
        }

        public virtual HeroAttribute TotalAttributes()
        {
            
            HeroAttribute totalAttributes = new(BaseAttributes.Strength, BaseAttributes.Dexterity, BaseAttributes.Intelligence);

            foreach (var item in Equipment.Values)
            {
                if (item is Armor armor)
                {
                    totalAttributes = totalAttributes.Add(armor.ArmorAttribute);
                }
                
            }
            return totalAttributes;
        }

        public abstract double Damage();
    }
}
