using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    
    class GameSellingManager : IGameSellingService
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " sold to " + (game.GamePrice - (game.GamePrice*campaign.SaleRate)));
        }
    }
}
