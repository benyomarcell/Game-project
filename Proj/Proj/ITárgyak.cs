using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface ITárgyak
    {
        string Kard { get; }
        string Landzsa { get; }
        string Kes { get; }
        string Pisztoly { get; }
        string Fejsze { get; }

        void AttackPlayer(IJátékos player);
    }

}
