using GameDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Abstract
{
	public interface ICampaignService
	{
		void Add(Campaign campaign);
		void Update(Campaign campaign);
		void Delete(Campaign campaign);
	}
}
