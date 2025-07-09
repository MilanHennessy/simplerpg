using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaxDmg { get; set; }
        public int RewardExpPoints { get; set; }
        public int RewardGold { get; set; }

    }
}
