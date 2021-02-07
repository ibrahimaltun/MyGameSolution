using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Entities;
using MyGameProject.Interface;

namespace MyGameProject.CampaignEntities
{
    public class StudentCampaign : ICampaignService
    {
        public void CampaignSalePrice(Game game)
        {
            Console.WriteLine("The sale price of this game is " + game.Price + " TL");
            Console.WriteLine("Discount were applied for 'STUDENT' campaign.");
            game.Price -= game.Price * (0.4);
            Console.WriteLine("!!! The sale price with a campaign is " + game.Price + " TL");
        }
    }
}
