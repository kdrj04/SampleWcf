using System;
using System.ServiceModel;
using Sample.Controct;

namespace Sample.Client
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (ChannelFactory<ICalculatorService> channelFactory = new ChannelFactory<ICalculatorService>("calculatorservice"))
			{
				ICalculatorService proxy = channelFactory.CreateChannel ();
				using (proxy as IDisposable) 
				{
					Console.WriteLine ("x + y = {2} when x = {0} and y ={1}", 3, 5, proxy.Add (3, 5));
				}
			}
			Console.WriteLine ("Hello World!");
			Console.ReadKey ();
		}
	}
}
