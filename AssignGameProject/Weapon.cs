using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGameProject
{
    public class Weapon :Item
    {
        public WeaponTypes WeaponType { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(string name, int requiredLevel, WeaponTypes weaponType, int weaponDamage)
            : base(name, requiredLevel, SlotEnumsTypes.Weapon)  
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }

    }
}
