using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface IObjects
    {
        string Sword { get; }
        string Spears { get; }
        string Knife { get; }
        string Gun { get; }
        string Axe { get; }

        void AttackPlayer(IPlayer player);
    }

}
