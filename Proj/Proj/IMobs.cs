using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface IMobs
    {
        string Name { get; }
        int Health { get; }
        int Attack { get; }
        int Defense { get; }
        int Xp { get; }

        void AttackPlayer(IPlayer player);
    }
}
