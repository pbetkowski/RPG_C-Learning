using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuests
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuests (Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
