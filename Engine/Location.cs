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
        public Quest QuestHere { get; set; }
        public Monster MonsterHere { get; set; }
        public Location LocationNorth { get; set; }
        public Location LocationEast { get; set; }
        public Location LocationSouth { get; set; }
        public Location LocationWest { get; set; }

        public Location(int id, string name, string desc, Item itemReqToEnter = null, 
            Quest questHere = null, Monster monsterHere = null)
        {
            ID = id;
            Name = name;
            Desc = desc;
            ItemReqToEnter = itemReqToEnter;
            QuestHere = questHere;
            MonsterHere = monsterHere;
        }
    }
}
