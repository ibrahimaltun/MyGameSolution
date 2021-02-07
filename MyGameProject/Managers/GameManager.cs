using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Entities;
using MyGameProject.Interface;

namespace MyGameProject.Managers
{
    public class GameManager
    {
        List<Game> games = new List<Game> { };

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("\n The game named " 
                +game.Name+" has been added to the "
                +game.Category+" category.");
        }

        public void Delete(string Name)
        {
            foreach (var game in games)
            {
                if (game.Name == Name)
                {
                    games.Remove(game);
                    Console.WriteLine("\nThe game named '"
                        +game.Name+"' has been deleted.");
                    break;
                }
                else 
                {
                    continue;
                }
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine("Information is Updated.");
        }

        public void ListGame(Game game)
        {
            int i = 1;
            Console.WriteLine("Games");
            foreach (var games in games)
            {
                Console.WriteLine("\nGame Name : "+game.Name
                                + "\nGame Category : "+game.Category 
                                + "\nGame Price : "+game.Price+"TL");
                Console.WriteLine("-------------------------------");
                i += 1;
            }
        }

        public void BuyGame(string Name, ICampaignService campaign)
        {
            foreach (var game in games)
            {
                if (game.Name == Name)
                {
                    campaign.CampaignSalePrice(game);
                }
                else
                {
                    continue;
                }
            }
        }

        internal void ListGame()
        {
            throw new NotImplementedException();
        }
    }
}
