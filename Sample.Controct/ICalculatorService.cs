using System;
using System.ServiceModel;

namespace Sample.Controct
{
	[ServiceContract]
	public interface ICalculatorService
	{
		[OperationContractAttribute]
		double Add(double x,double y);
	}
}

