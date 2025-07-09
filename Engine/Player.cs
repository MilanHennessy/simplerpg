using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<ItemInventory> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Player(int gold, int experiencePoints, int level, int currentHitPoints,
            int maxHitPoints) : base(currentHitPoints, maxHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<ItemInventory>();
            Quests = new List<PlayerQuest>();
        }
    }
}
