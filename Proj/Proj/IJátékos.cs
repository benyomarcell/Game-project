using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface IJátékos
    {
        string Name { get; }
        int Health { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        List<ITárgyak> Inventory { get; }
        ISzobák CurrentRoom { get; set; }
        void AttackCreature(ILények creature);
        void UseItem(ITárgyak item);
    }
}
