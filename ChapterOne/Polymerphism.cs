using System;
using System.Runtime.CompilerServices;
namespace lab1
{
	public class StaticPolyMorph
	{
		public void Print(int num)
		{
			Console.WriteLine("int : {0} was passed as argument.",num);
		}

        public void Print(string str)
        {
            Console.WriteLine("String : {0} was passed as argument.", str);
        }
    }

	// Showing dynamic polymorhism using method overriding
	public class Animal
	{
		public void Speak()
		{
			Console.WriteLine("An animal made sound.");
			//Console.WriteLine("An animal {0}ed", voice);
		}
	}

	public class Dog:Animal
	{
		public void Speak(string sound)
		{
			Console.WriteLine("A dog {0}",sound);
		}
	}
}

