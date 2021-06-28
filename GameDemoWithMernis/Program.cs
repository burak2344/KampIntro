using GameDemoWithMernis.Abstract;
using GameDemoWithMernis.Adapters;
using GameDemoWithMernis.Concrete;
using GameDemoWithMernis.Entities;
using System;

namespace GameDemoWithMernis
{
	class Program
	{
		static void Main(string[] args)
		{
            User user1 = new User()
            {
                FirstName = "Sample Name",
                LastName = "Sample Last Name",
                DateOfBirth = new DateTime(1996, 12, 06),
                NationalityId = "14725836912"
            };

            UserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(user1);

            Console.WriteLine("------------");

            Game game1 = new Game() {  GameName = "FIFA 21", Price = 150 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("------------");

            Campaign campaign1 = new Campaign() {  CampaignName = "Açılış Kampanyası", Discount = 0.7 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            Console.WriteLine("------------");

            OrderManager orderManager = new OrderManager();
            orderManager.CampWithSale(user1, game1, campaign1);
            orderManager.CampWithoutSale(user1, game1);
            Console.ReadLine();
        }
	}
}
