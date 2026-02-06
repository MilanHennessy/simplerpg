using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public Item ItemReqToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, string name, string desc, Item itemReqToEnter = null, 
            Quest questHere = null, Monster monsterHere = null)
        {
            ID = id;
            Name = name;
            Desc = desc;
            ItemReqToEnter = itemReqToEnter;
            QuestAvailableHere = questHere;
            MonsterLivingHere = monsterHere;
        }
    }
}
