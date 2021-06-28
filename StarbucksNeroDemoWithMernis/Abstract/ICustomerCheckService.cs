using StarbucksNeroDemoWithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksNeroDemoWithMernis.Abstract
{
	public interface ICustomerCheckService
	{
		bool CheckIfRealPerson(Customer customer);
	}
}
