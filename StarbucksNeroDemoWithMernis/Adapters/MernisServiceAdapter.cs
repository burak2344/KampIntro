using MernisServiceReference;
using StarbucksNeroDemoWithMernis.Abstract;
using StarbucksNeroDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksNeroDemoWithMernis.Adapters
{
	public class MernisServiceAdapter : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
			return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
		}
	}
}
