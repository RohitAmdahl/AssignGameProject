using System;
using System.Collections.Generic;

namespace AssignGameProject
{
    public class Mage : Hero
    {
        // constructor
        public Mage(string name) : base(name)
        {
            BaseAttributes = new HeroAttribute(1, 1, 8);
            ValidWeaponTypes = new List<WeaponTypes> { WeaponTypes.Staffs, WeaponTypes.Wands };
            ValidArmorTypes = new List<ArmorTypes> { ArmorTypes.Cloth };
        }

        public override void LevelUp()
        {
            Level++;
            BaseAttributes.Increase(1, 1, 5);  
        }

        public override double Damage()
        {
            Weapon weapon = Equipment[SlotEnumsTypes.Weapon] as Weapon;
            double baseDamage = weapon?.WeaponDamage ?? 1; 
            double intelligence = TotalAttributes().Intelligence;
            return baseDamage * (1 + intelligence / 100.0);
        }
    }
}
