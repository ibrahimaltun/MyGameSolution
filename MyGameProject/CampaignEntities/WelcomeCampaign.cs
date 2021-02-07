using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Entities;
using MyGameProject.Interface;

namespace MyGameProject.CampaignEntities
{
    public class WelcomeCampaign : ICampaignService
    {
        public void CampaignAdd(Game game)
        {
            Console.WriteLine("This campaign has been added.");
        }

        public void CampaignDelete(Game game)
        {
            Console.WriteLine("This campaign has been deleted");
        }

        public void CampaignSalePrice(Game game)
        {
            Console.WriteLine("The sale price of this game is " + game.Price + " TL");
            Console.WriteLine("Discount were applied for 'NEW YEAR' campaign.");
            game.Price -= game.Price * (0.1);
            Console.WriteLine("!!! The sale price with a campaign is " + game.Price + " TL");
        }
    }
}
