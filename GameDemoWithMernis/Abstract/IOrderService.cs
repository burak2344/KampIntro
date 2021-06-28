using GameDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Abstract
{
	public interface IOrderService
	{
		void CampWithSale(User user, Game game, Campaign campaign);
		void CampWithoutSale(User user, Game game);
	}
}
