using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
	public class ProviderDirectoryEntry
	{
		private string serviceName;
		private int serviceCode;
		private double serviceFee;


		public ProviderDirectoryEntry()
		{

		}

		public ProviderDirectoryEntry(string serviceName, int serviceCode, double serviceFee)
		{
			this.serviceName = serviceName;
			this.serviceCode = serviceCode;
			this.serviceFee = serviceFee;
		}

		public string getServiceName()
		{
			return serviceName;
		}

		public void setServiceName(String serviceName)
		{
			this.serviceName = serviceName;
		}

		public int getServiceCode()
		{
			return serviceCode;
		}

		public void setServiceCode(int serviceCode)
		{
			this.serviceCode = serviceCode;
		}

		public double getServiceFee()
		{
			return serviceFee;
		}

		public void setServiceFee(double serviceFee)
		{
			this.serviceFee = serviceFee;
		}

		//private class sortByServiceName
		//{
		//	int Compare(object pde1, object pde2)
		//	{
		//		ProviderDirectoryEntry entry1 = (ProviderDirectoryEntry)pde1;
		//		ProviderDirectoryEntry entry2 = (ProviderDirectoryEntry)pde2;

		//		string ServiceName1 = entry1.getServiceName().ToUpper();
		//		string ServiceName2 = entry2.getServiceName().ToUpper();

		//		if (String.Compare(ServiceName1, ServiceName2) == 1)
		//			return 1;
		//		if (String.Compare(ServiceName1, ServiceName2) == -1)
		//			return -1;
		//		else
		//			return 0;
		//	}
		//}
		//public static IComparer ServiceNameComparator()
		//{
		//	return (IComparer)new sortByServiceName();
		//}
	}
}
