using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Burak",LastName="Yünkül",City="Elazığ" };
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.City = "Ankara";
            Customer customer3 = new Customer(3,"Fatih","Demirel","Bursa");
            Console.WriteLine(customer3.FirstName);
            
        }
        
    }

    class Customer
    {
        public Customer()
        {

        }
        //default Constructors
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
