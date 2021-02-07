using System;
using MyGameProject.CampaignEntities;
using MyGameProject.Entities;
using MyGameProject.Interface;
using MyGameProject.Managers;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(new Player()
            {
                Tc = "10808198724",
                Name = "İbrahim",
                Surname = "ALTUN",
                YearOfBirth = 1997
            });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game()
            {
                Name="GTA V",
                Category = "Entertainment",
                Price = 135
            });

            while (true)
            {
                Console.WriteLine("\nOptions");
                Console.WriteLine("\n(PA) : Player Add " +
                                  "\n(PD) : Player Delete"+
                                  "\n(PL) : Player List"+
                                  "\n(GA) : Game Add"+
                                  "\n(GD) : Game Delete"+
                                  "\n(GL) : Game List"+
                                  "\n(CC) : Choise Campaign"+
                                  "\n(E) : Exit");
                string x = Console.ReadLine();

                if (x == "PA")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the Player Information you want to add...");
                    
                    Console.WriteLine("Tc : ");
                    string TcNo = Console.ReadLine();

                    Console.WriteLine("Name : ");
                    string PlayerName = Console.ReadLine();

                    Console.WriteLine("Surname : ");
                    string PlayerSurname = Console.ReadLine();

                    Console.WriteLine("Year Of Birth : ");
                    int BirthYear = Convert.ToInt32(Console.ReadLine());

                    ValidateManager validateManager = new ValidateManager();
                    validateManager.Validate(new Person
                    {
                        Tc=TcNo,
                        Name=PlayerName,
                        Surname=PlayerSurname,
                        YearOfBirth=BirthYear
                    });
                }

                else if (x == "PD")
                {
                    Console.WriteLine("Enter the name of the player you want to delete: ");
                    playerManager.Delete(Console.ReadLine());
                }

                else if (x == "PL")
                {
                    Console.Clear();
                    playerManager.ListPlayer();
                }

                else if (x == "GA")
                {
                    Console.WriteLine("Enter the information of the game you want to add : ");
                    
                    Console.WriteLine("Game Name : ");
                    string Name = Console.ReadLine();

                    Console.WriteLine("Game Category : ");
                    string Category = Console.ReadLine();

                    Console.WriteLine("Game Price :");
                    double Price = Convert.ToDouble(Console.ReadLine());

                    gameManager.Add(new Game()
                    {
                        Name = Name,
                        Category = Category,
                        Price = Price
                    });

                }

                else if (x == "GL")
                {
                    Console.Clear();
                    gameManager.ListGame();
                }

                else if (x == "CC")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Campaigns " +
                                          "\n(1) Welcome Campaign" +
                                          "\n(2) New Year Campaign " +
                                          "\n(3) Student Campaign " +
                                          "\n(4) Menü");
                        Console.WriteLine("--------------------------");

                        int x2 = Convert.ToInt32(Console.ReadLine());

                        if(x2 == 1)
                        {
                            gameManager.ListGame();
                            
                            Console.WriteLine("Write the name of the game you want to apply 'Welcome Campaign' from the games above: ");
                            string name = Console.ReadLine();

                            ICampaignService campaignService = new WelcomeCampaign();
                            gameManager.BuyGame(name, campaignService);
                        }

                        else if (x2 == 2)
                        {
                            gameManager.ListGame();

                            Console.WriteLine("Write the name of the game you want to apply 'New Year Campaign' from the games above: ");
                            string name = Console.ReadLine();

                            ICampaignService campaignService = new NewYearCampaign();
                            gameManager.BuyGame(name, campaignService);
                        }

                        else if (x2 == 3)
                        {
                            gameManager.ListGame();

                            Console.WriteLine("Write the name of the game you want to apply 'Student Campaign' from the games above: ");
                            string name = Console.ReadLine();

                            ICampaignService campaignService = new StudentCampaign();
                            gameManager.BuyGame(name, campaignService);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
            }
        }
    }
}
