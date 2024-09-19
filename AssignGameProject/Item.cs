using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGameProject
{
    public abstract class Item
    {
        // properties
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public SlotEnumsTypes Slot { get; set; }

        public Item(string name, int requiredLevel, SlotEnumsTypes slot )

        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;

        }

    }
}
