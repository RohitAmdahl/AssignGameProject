using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGameProject
{
    // Properties 
    public class HeroAttribute
    {

        // Properties
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        // Constructor
        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
        }

        //public void Increase(int strengthIncrease, int dexterityIncrease, int intelligenceIncrease)
        //{
        //    Strength + strengthIncrease;
        //    Dexterity + dexterityIncrease;
        //    Intelligence + intelligenceIncrease;
        //}

        

        internal HeroAttribute Add(HeroAttribute armorAttribute)
        {
            throw new NotImplementedException();
        }
    }

}
