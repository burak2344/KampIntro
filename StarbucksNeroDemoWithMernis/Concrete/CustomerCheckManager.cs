using StarbucksNeroDemoWithMernis.Abstract;
using StarbucksNeroDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksNeroDemoWithMernis.Concrete
{
	public class CustomerCheckManager : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			return true;
		}
	}
}
