using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcrendszer
{
    public class GameController
    {
        private List<Player> players = new List<Player>();  
        private List<Weapon> weapons = new List<Weapon>();   

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void AddWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
        }

        public void StartBattle()
        {
           
            var random = new Random();
            var player = players[random.Next(players.Count)];
            var weapon = weapons[random.Next(weapons.Count)];

            Console.WriteLine($"{player.Name} támad {weapon.Name}-val!");

       
            var hitChance = random.Next(101);   
            if (hitChance <= weapon.Accuracy)
            {
                
                var damage = weapon.Damage;
                player.Health -= damage;
                Console.WriteLine($"A támadás eltalálta! {damage} sebzést okozott.");
                Console.WriteLine($"Az ellenfél életereje: {player.Health}");
            }
            else
            {
               
                Console.WriteLine("A támadás elhibázódott!");
            }
        }
    }

}
