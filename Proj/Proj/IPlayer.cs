using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface IPlayer
    {
        string Name { get; }
        int Health { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        List<IObjects> Inventory { get; }
        IRooms CurrentRoom { get; set; }
        void AttackCreature(IMobs creature);
        void UseItem(IObjects item);
    }
}

