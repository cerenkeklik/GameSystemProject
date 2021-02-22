using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameSellingService
    {
        void Sell(Game game,Gamer gamer, Campaign campaign);
    }
}
