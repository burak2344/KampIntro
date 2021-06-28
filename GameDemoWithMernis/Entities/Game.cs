using GameDemoWithMernis.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Entities
{
	public class Game:IEntity
	{
		public int Id { get; set; }
		public string GameName { get; set; }
		public int Price { get; set; }
	}
}
