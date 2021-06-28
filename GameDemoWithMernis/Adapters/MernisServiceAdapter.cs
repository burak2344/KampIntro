using GameDemoWithMernis.Abstract;
using GameDemoWithMernis.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoWithMernis.Adapters
{
	class MernisServiceAdapter : IUserValidateService
	{
		public bool CheckIfRealPerson(User user)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
			return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
		}
	}
}
