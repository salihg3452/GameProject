using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            int newCampaignPrice = game.Price - campaign.CampaignPrice;
            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " oyununu KAMPANYALI fiyattan satın almıştır. Kampanyalı Fiyatı: " + newCampaignPrice);
        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " oyununu satın almıştır. Fiyatı: " + game.Price);
        }
    }
}
