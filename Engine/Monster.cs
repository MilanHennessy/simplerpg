using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDmg { get; set; }
        public int RewardExpPoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
        public Monster(int id, string name, int maxDmg, int rewardExpPoints, int rewardGold,
            int currentHitPoints, int maxHitPoints) :
            base(currentHitPoints,maxHitPoints)
        {
            ID = id;
            Name = name;
            MaxDmg = maxDmg;
            RewardExpPoints = rewardExpPoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }

    }
}
