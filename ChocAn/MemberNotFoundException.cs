using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
	public class MemberNotFoundException : Exception
	{
		public MemberNotFoundException() : base()
		{
		}

		public MemberNotFoundException(string message) : base(message)
		{
		}
	}
}
