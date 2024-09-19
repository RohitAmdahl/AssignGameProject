using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGameProject
{
    public class Ranger : Hero
    { 
        public Ranger(string name) : base(name)
        {
            BaseAttributes = new HeroAttribute(1, 7, 1);
            ValidWeaponTypes = new List<WeaponTypes> { WeaponTypes.Bows };
            ValidArmorTypes = new List<ArmorTypes> { ArmorTypes.Leather, ArmorTypes.Mail }; 
        }
        public override void LevelUp()
        {
            Level++;
            BaseAttributes.Increase(1, 1, 5);  
        }

        public override double Damage()
        {
            Weapon weapon = Equipment[SlotEnumsTypes.Weapon] as Weapon;
            double baseDamage = weapon?.WeaponDamage ?? 1;  // Default to 1 if no weapon is equipped
            double dexterity = TotalAttributes().Dexterity;  // Rogues rely on Dexterity for damage
            return baseDamage * (1 + dexterity / 100.0);
        }
    }
}
