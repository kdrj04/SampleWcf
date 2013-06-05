using System;
using Sample.Controct;

namespace Sample.Service
{
	public class CalculatorService:ICalculatorService
	{
		public double Add (double x, double y)
		{
			return x + y;
		}
	}
}

