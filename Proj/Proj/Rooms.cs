using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proj.Rooms;

namespace Proj
{
    internal class Rooms
    {
        public class Room : IRooms
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public List<IObjects> Items { get; set; }
            public List<IMobs> Creatures { get; set; }
            public IRooms North { get; set; }
            public IRooms South { get; set; }
            public IRooms East { get; set; }
            public IRooms West { get; set; }
        }
    }
}
