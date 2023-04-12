using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal interface ISzobák
    {
        string Name { get; }
        string Description { get; }
        List<ITárgyak> Items { get; }
        List<ILények> Creatures { get; }
        ISzobák North { get; }
        ISzobák South { get; }
        ISzobák East { get; }
        ISzobák West { get; }
    }
}
