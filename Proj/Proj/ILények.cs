using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface ILények
    {
        string Name { get; }
        int Health { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        void AttackPlayer(IJátékos player);
    }
}
