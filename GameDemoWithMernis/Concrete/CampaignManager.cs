using System;
using System.Collections.Generic;
using System.Text;
using GameDemoWithMernis.Abstract;
using GameDemoWithMernis.Entities;



namespace GameDemoWithMernis.Concrete
{
	class CampaignManager : ICampaignService
	{
		public void Add(Campaign campaign)
		{
			Console.WriteLine("Yeni kampanya eklendi.\n Kampanya ismi: " + campaign.CampaignName);
		}

		public void Delete(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + " kampanyalardan çıkarıldı.");
		}

		public void Update(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + " kampanya başarıyla güncellendi.");
		}
	}
}
