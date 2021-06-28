﻿using GameDemoWithMernis.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Entities
{
	public class Campaign:IEntity
	{
		public int Id { get; set; }
		public string CampaignName { get; set; }
		public double Discount { get; set; }
	}
}
