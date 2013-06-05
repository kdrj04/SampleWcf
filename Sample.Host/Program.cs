using System;
using System.ServiceModel;
using Sample.Controct;
using Sample.Service;

namespace Sample.Host
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
			{
				host.Opened += (object sender, EventArgs e) => 
				{
					Console.WriteLine("CalculatorService已经启动,按任意键终止服务!");
				};
				host.Open ();
				Console.Read ();
			}
		}
	}
}
