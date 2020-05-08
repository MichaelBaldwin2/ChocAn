using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
	public class ProviderNotFoundException : Exception
	{
		public ProviderNotFoundException() : base()
		{
		}

		public ProviderNotFoundException(string message) : base(message)
		{
		}
	}
}
