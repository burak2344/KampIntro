using StarbucksNeroDemoWithMernis.Abstract;
using StarbucksNeroDemoWithMernis.Adapters;
using StarbucksNeroDemoWithMernis.Concrete;
using StarbucksNeroDemoWithMernis.Entities;
using System;

namespace StarbucksNeroDemoWithMernis
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager customerManager = new NeroCustomerManager();
			customerManager.Save(new Customer { DateOfBirth = new DateTime(1996, 9, 6),FirstName="Ahmet Burak",LastName="Yünkül",NationalityId="25825812345" });
			BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());
			customerManager2.Save(new Customer { DateOfBirth = new DateTime(2007, 9, 17), FirstName = "Taha Berke", LastName = "Yünkül", NationalityId = "123456789" });
			//BaseCustomerManager customerManager3 = new StarbucksCustomerManager(new MernisServiceAdapter());
			//customerManager3.Save(new Customer { DateOfBirth = new DateTime(2007, 9, 17), FirstName = "Ahmet Burak", LastName = "Yünkül", NationalityId = "12345678912" });

			Console.ReadLine();
		}
	}
}
