using System;

namespace InterfacesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IWorker[] workers = new IWorker[3]
			{
				new Manager(),
				new Worker(),
				new Robot(),
			};

			foreach (var worker in workers)
			{
				worker.Work();
			}

			IEat[] eat = new IEat[2]
			{
				new Manager(),
				new Worker(),
			};

			foreach (var eats in eat)
			{
				eats.Eat();
			}
		}
	}

	interface IWorker
	{
		void Work();

	}

	interface IEat
	{
		void Eat();
	}

	interface ISalary
	{
		void GetSalary();
	}

	class Manager : IWorker, ISalary, IEat
	{
		public void Eat()
		{
			Console.WriteLine("Manager Eat");
		}

		public void GetSalary()
		{
			throw new NotImplementedException();
		}

		public void Work()
		{
			Console.WriteLine("Manager Work");
		}
	}

	class Worker : IWorker, ISalary, IEat
	{
        public void Eat()
		{
			Console.WriteLine("Worker Eat");
		}

		public void GetSalary()
		{
			throw new NotImplementedException();
		}

		public void Work()
		{
			Console.WriteLine("Worker Work");
		}
	}

	class Robot : IWorker
	{
		public void Work()
		{
			Console.WriteLine("Robot Work");
		}
	}
}
