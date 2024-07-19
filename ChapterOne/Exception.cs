using System;
namespace lab1
{
	public class CustomExceptionHandler
	{
		public double Divide(double x, double y)
		{
			try
			{
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                return ( x / y);
			}
			catch(DivideByZeroException)
			{
				Console.WriteLine("Err: Division by 0");
				return 0;
			}
		}
	}
}

