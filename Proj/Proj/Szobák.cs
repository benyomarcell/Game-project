using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proj.Szobák;

namespace Proj
{
    internal class Szobák
    {
        public class Room : ISzobák
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public List<ITárgyak> Items { get; set; }
            public List<ILények> Creatures { get; set; }
            public ISzobák North { get; set; }
            public ISzobák South { get; set; }
            public ISzobák East { get; set; }
            public ISzobák West { get; set; }
        }
    }
}
