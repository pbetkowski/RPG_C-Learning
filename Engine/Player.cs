using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Creature
    {
       
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public Player(int gold, int exp, int level, int currentHP, int maxHP) : base(maxHP, currentHP)
        {
            Gold = gold;
            ExperiencePoints = exp;
            Level = level;
        }
    }
}
