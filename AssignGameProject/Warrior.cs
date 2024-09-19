using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGameProject
{
    public class Warrior : Hero
    {
        public Warrior(string name ) :base (name)
        {
            BaseAttributes = new HeroAttribute(5, 2, 1);
            ValidWeaponTypes = new List<WeaponTypes> { WeaponTypes.Axes, WeaponTypes.Hammers, WeaponTypes.Swords };
            ValidArmorTypes = new List<ArmorTypes> { ArmorTypes.Cloth, ArmorTypes.Plate };
        }


        public override void LevelUp()
        {
            Level++; // Increment the level
            BaseAttributes.Increase(3, 2, 1); // Adjust attribute increases for a Warrior class
        }

        public override double Damage()
        {
            Weapon weapon = Equipment[SlotEnumsTypes.Weapon] as Weapon;
            double baseDamage = weapon?.WeaponDamage ?? 1;
            double strength = TotalAttributes().Strength;
            return baseDamage * (1 + strength / 100.0);
        }
        

        
    }
}
