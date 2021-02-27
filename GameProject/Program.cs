using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            SaleManager saleManager = new SaleManager();

            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());


            gamerManager1.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "SALİH",
                LastName = "GÜL",
                IdentityNumber = 123123
            });

            Gamer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "salih",
                LastName = "Gül",
                BirthYear = 2000,
                IdentityNumber = 123456
            };
            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Metro 2033",
                Price = 150
            };
            Game game2 = new Game()
            {
                Id = 2,
                GameName = "Grand Theft Auto 5",
                Price = 265
            };

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Efsane Cuma",
                CampaignPrice = 50
            };
            Campaign campaign2 = new Campaign()
            {
                Id = 2,
                CampaignName = "Fırsat Köşesi",
                CampaignPrice = 75
            };

            //Normal Fiyat
            saleManager.Sale(gamer, game1);
            
            //Kampanyalı Fiyat
            saleManager.CampaignSale(gamer, game2, campaign1);


            Console.ReadKey();
        }
    }
}
