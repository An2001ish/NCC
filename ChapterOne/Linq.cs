using System;
using System.Linq;

namespace lab1
{
	public class Linq
	{
		public int[] number_list = {};

		public void NumberList(int[] number_list)
		{
			this.number_list = number_list;
		}

		public int[] GetEvenList(bool count)
		{
			var even_numbers = number_list.Where(n => n % 2 == 0);
			var even_list = even_numbers.ToArray();
			if(count==true)
			{
                Console.WriteLine("Number of even numbers = {0}", even_list.Length);
            }
			Console.WriteLine("Even List");
			return even_list;
		}

        public int[] GetOddList(bool count)
        {
            var odd_numbers = number_list.Where(n => n % 2 == 1);
            var odd_list = odd_numbers.ToArray();
            if (count == true)
            {
                Console.WriteLine("Number of even numbers = {0}", odd_list.Length);
            }
            Console.WriteLine("Odd List");
            return odd_list;
        }
    }
}

