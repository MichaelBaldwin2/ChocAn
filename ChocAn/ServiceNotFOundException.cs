using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
	class ServiceNotFoundException : Exception
	{
		public ServiceNotFoundException() : base()
		{
		}

		public ServiceNotFoundException(string message) : base(message)
		{
		}
	}
}
