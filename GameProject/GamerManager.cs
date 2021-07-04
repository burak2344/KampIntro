using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GamerManager : IGamerService
	{
		IUserValidationService _uservalidationService;
        public GamerManager(IUserValidationService uservalidationService)
		{
			this._uservalidationService = uservalidationService;
		}

		public void Add(Gamer gamer)
		{
			if (_uservalidationService.Validate(gamer))
			{
				Console.WriteLine("Kayıt oldu");
			}
			else
			{
				Console.WriteLine("Doğrulama ve kayıt başarısız.");
			}
			
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("Kayıt silindi");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine("Kayıt güncellendi");
		}
	}
}
