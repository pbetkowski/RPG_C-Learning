using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public List<LootItem> LootItems;

        public Monster (int id, string name, int maximumDmg, int rewardExperiencePoints, int rewardGold, int currentHP, int maximumHP) : base(maximumHP, currentHP)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDmg;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            LootItems = new List<LootItem>();
        }
    }
}
