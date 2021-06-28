using GameDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Abstract
{
	public interface IUserValidateService
	{
		bool CheckIfRealPerson(User user);
	}
}
