using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game);
        void CampaignSale(Gamer gamer, Game game, Campaign campaign);
    }
}
