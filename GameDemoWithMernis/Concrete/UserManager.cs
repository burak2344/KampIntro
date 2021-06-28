using GameDemoWithMernis.Abstract;
using GameDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Concrete
{
	class UserManager : IUserService
	{
		IUserValidateService _validateService;

		public UserManager(IUserValidateService validateService)
		{
			_validateService = validateService;
		}

		public void Add(User user)
		{
			if (_validateService.CheckIfRealPerson(user))
			{
				Console.WriteLine(user.FirstName + " eklendi");
			}
			else
			{
				
				Console.WriteLine(user.FirstName + " ismine ait kimlik doğrulama sorunu");
			}
			
		}

		public void Delete(User user)
		{
			Console.WriteLine(user.FirstName + " silindi");
		}

		public void Update(User user)
		{
			Console.WriteLine(user.FirstName + " güncellendi");
		}
	}
}
