using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChocAn
{
	public class Record
	{
		public string CurrentDate { get; private set; }
		public string ServiceDate { get; private set; }
		public string ProviderNumber { get; private set; }
		public string MemberNumber { get; private set; }
		public string ServiceCode { get; private set; }
		public string Comments { get; private set; }

		public Record()
		{
			CurrentDate = "";
			ServiceDate = "";
			ProviderNumber = "";
			MemberNumber = "";
			ServiceCode = "";
			Comments = "";
		}

		public Record(string currentDate, string serviceDate, string providerNumber, string memberNumber, string serviceCode, string comments)
		{
			CurrentDate = currentDate;
			ServiceDate = serviceDate;
			ProviderNumber = providerNumber;
			MemberNumber = memberNumber;
			ServiceCode = serviceCode;
			Comments = comments;
		}

		public void Save(XElement parentNode)
		{
			parentNode.Add(
				new XElement("CurrentDate", CurrentDate),
				new XElement("ServiceDate", ServiceDate),
				new XElement("ProviderNumber", ProviderNumber),
				new XElement("MemberNumber", MemberNumber),
				new XElement("ServiceCode", ServiceCode),
				new XElement("Comments", Comments));
		}

		public void Load(XElement parentNode)
		{
			foreach (var iChild in parentNode.Elements())
			{
				switch (iChild.Name.ToString())
				{
					case "CurrentDate":
						CurrentDate = iChild.Value;
						break;
					case "ServiceDate":
						ServiceDate = iChild.Value;
						break;
					case "ProviderNumber":
						ProviderNumber = iChild.Value;
						break;
					case "MemberNumber":
						MemberNumber = iChild.Value;
						break;
					case "ServiceCode":
						ServiceCode = iChild.Value;
						break;
					case "Comments":
						Comments = iChild.Value;
						break;
				}
			}
		}
	}
}
