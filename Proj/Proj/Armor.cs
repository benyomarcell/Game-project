using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal class Armor
    {
        public class Armor : IArmor
        {
            public string Name { get; }
            public string Description { get; }
            public int Armor { get; }
            public int Toughness { get; }
        }
    }
}
