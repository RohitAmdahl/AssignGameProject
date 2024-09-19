using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGameProject
{
    public class Armor:Item
    {
        public ArmorTypes ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }

        public Armor(string name, int requiredLevel, ArmorTypes armorType, HeroAttribute armorAttribute)
            : base(name, requiredLevel, SlotEnumsTypes.Body)
        {
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }

    }
}
