using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {   Id=1,
                IdentityNumber=12345,
                LastName="Keklik",
                FirstName="Ceren",
                BirthYear=1999 });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {SaleRate=20 });

            GameSellingManager gameSellingManager = new GameSellingManager();
            gameSellingManager.Sell(
                new Game
                {
                    GameId = 1,
                    DateOfPublish = DateTime.Now,
                    GameName = "Valorant",
                    GamePrice = 500
                },
               new Gamer
               {
                   Id = 1,
                   IdentityNumber = 12345,
                   LastName = "Keklik",
                   FirstName = "Ceren",
                   BirthYear = 1999
               },
               new Campaign
               {
                   SaleRate = 0.2
               }
                );
        }
    }
}
