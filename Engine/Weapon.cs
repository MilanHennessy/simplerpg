using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {

        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }

        public Weapon(int id, string name, string namePlural, int maxDmg, int minDmg) :
            base(id, name, namePlural)
        {
            MinDmg = minDmg;
            MaxDmg = maxDmg;
        } 
    }
}
