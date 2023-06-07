using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface IRooms
    {
        string Name { get; }
        string Description { get; }
        List<IObjects> Items { get; }
        List<IMobs> Creatures { get; }
        IRooms North { get; }
        IRooms South { get; }
        IRooms East { get; }
        IRooms West { get; }
    }
}
