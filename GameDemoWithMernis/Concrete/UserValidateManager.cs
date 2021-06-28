using GameDemoWithMernis.Abstract;
using GameDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Concrete
{
	class UserValidateManager : IUserValidateService
	{
		public bool CheckIfRealPerson(User user)
		{
			return true;
		}
	}
}
