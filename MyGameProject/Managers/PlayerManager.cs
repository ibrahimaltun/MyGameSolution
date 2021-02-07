using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Entities;

namespace MyGameProject.Managers
{
    public class PlayerManager
    {
        List<Player> players = new List<Player>() { };

        public void Add(Player player)
        {
            players.Add(player);
        }

        public void Update(Player player, int Id)
        {
            Console.WriteLine("Information is Updated.");
        }

        public void Delete(String Name)
        {
            foreach (var player in players)
            {
                if (player.Name == Name)
                {
                    players.Remove(player);
                    Console.WriteLine("Player named '" + player.Name + "' has been deleted.");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void ListPlayer()
        {
            Console.WriteLine("Players");
            int i = 1;

            foreach (var player in players)
            {
                Console.WriteLine("Name : "+player.Name+"\nSurname : "+player.Surname);
                Console.WriteLine("----------------------------------------");
                i += 1;
            }
        }
    }
}