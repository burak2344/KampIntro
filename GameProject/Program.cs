using System;

namespace GameProject
{
	class Program
	{
		static void Main(string[] args)
		{
			GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
			gamerManager.Add(new Gamer
			{
				Id = 1,
				FirstName = "BURAK",
				LastName = "YUNKUL",
				IdentityNumber = 123456,
				BirthYear = 1985
			});
		}
	}
}
