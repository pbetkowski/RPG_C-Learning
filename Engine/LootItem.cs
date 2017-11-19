using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }
        public bool IsDefault { get; set; }

        public LootItem (Item details, int quantity, bool isDefault)
        {
            Details = details;
            Quantity = quantity;
            IsDefault = isDefault;
        }
    }
}
