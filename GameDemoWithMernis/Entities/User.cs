using GameDemoWithMernis.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Entities
{
	public class User:IEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string NationalityId { get; set; }
	}
}
