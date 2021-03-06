using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCartNumber = "1234567890";
            Employee employee = new Employee();
            employee.FirstName = "Burak";
            Person person3 = customer;
            customer.FirstName = "Ahmet";
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCartNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            
        }
    }

    //base class:Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCartNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
