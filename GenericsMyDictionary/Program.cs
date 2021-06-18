using System;

namespace GenericsMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> cars = new MyDictionary<string>();
            cars.Add("Fiat Egea");
            cars.Add("Opel Corsa");
            cars.Add("Bmw A102");
            cars.Add("Honda Civic");
            Console.WriteLine(cars.Count);
        }
    }
}
