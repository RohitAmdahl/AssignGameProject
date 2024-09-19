using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGameProject
{
    public class Rogue : Hero
         
    {
        public Rogue(string name) : base(name)
        {
            BaseAttributes = new HeroAttribute(2, 6, 1);
            ValidWeaponTypes = new List<WeaponTypes> { WeaponTypes.Daggers, WeaponTypes.Swords };
            ValidArmorTypes = new List<ArmorTypes> { ArmorTypes.Leather, ArmorTypes.Mail };
        }
        public override void LevelUp()
        {
            Level++;
            BaseAttributes.Increase(1, 4, 1);
        }
        public override double Damage()
        {
            Weapon weapon = Equipment[SlotEnumsTypes.Weapon] as Weapon;
            double baseDamage = weapon?.WeaponDamage ?? 1;
            double dexterity = TotalAttributes().Dexterity;
            return baseDamage * (1 + dexterity / 100.0);
        }
    }
}
