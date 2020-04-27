using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
	class RecordNotFoundException : Exception
	{
		public RecordNotFoundException() : base()
		{
		}

		public RecordNotFoundException(string message) : base(message)
		{
		}
	}
}
