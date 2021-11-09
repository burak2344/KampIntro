﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	public delegate void MyDelegate();
	public delegate void MyDelegate2(string text);
	public delegate int MyDelagate3(int number1, int number2);
	class Program
	{
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager();
			//customerManager.SendMessage();
			//customerManager.ShowAlert();


			MyDelegate myDelegate = customerManager.SendMessage;
			myDelegate += customerManager.ShowAlert;
			myDelegate -= customerManager.ShowAlert;


			MyDelegate2 myDelegate2 = customerManager.SendMessage2;
			myDelegate2 += customerManager.ShowAlert2;

			Matematik matematik = new Matematik();
			MyDelagate3 myDelagate3 = matematik.Topla;



			myDelegate();
			myDelegate2("Hello");
			var sonuc = myDelagate3(2, 3);
			Console.WriteLine(sonuc);
			Console.ReadLine();

		}
	}


	public class CustomerManager
	{
		public void SendMessage()
		{
			Console.WriteLine("Hello");
		}

		public void ShowAlert()
		{
			Console.WriteLine("Be Careful");
		}

		public void SendMessage2(string message)
		{
			Console.WriteLine(message);
		}

		public void ShowAlert2(string alert)
		{
			Console.WriteLine(alert);
		}
	}

	public class Matematik
	{
		public int Topla(int sayi1,int sayi2)
		{
			return sayi1 + sayi2;
		}

		public int Carp(int sayi1, int sayi2)
		{
			return sayi1 * sayi2;
		}
	}
}
