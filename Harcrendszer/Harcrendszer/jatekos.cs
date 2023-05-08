using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harcrendszer;

namespace Harcrendszer
{
    public class Player
    {
        public string Name { get; set; }      // játékos neve
        public int Health { get; set; }       // életerő
        public Weapon CurrentWeapon { get; set; }  // használt fegyver
    }

}
