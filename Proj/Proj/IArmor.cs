using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface IArmor
    {
        string Name { get; }
        string Description { get; }
        int Armor { get; }
        int Toughness { get; }
    }
}
