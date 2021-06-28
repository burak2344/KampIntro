using GameDemoWithMernis.Abstract;
using GameDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Concrete
{
	class OrderManager : IOrderService
	{
		public void CampWithoutSale(User user, Game game)
		{
			Console.WriteLine(user.FirstName + " adlı kişi  " + game.GameName + " oyununu başarılı bir şekilde satınaldı.");
		}

		public void CampWithSale(User user, Game game, Campaign campaign)
		{
			Console.WriteLine(user.FirstName + " adlı kişi  " + game.GameName + " oyununu " + campaign.CampaignName + " ile beraber başarılı bir şekilde satın aldı.");
		}
	}
}
