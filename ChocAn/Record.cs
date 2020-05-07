using System.Linq;
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
		public float Fee { get; private set; }
		public Provider Provider { get { return DataCenter.RequestAllProviders().SingleOrDefault(p => p.Number == ProviderNumber); } }
		public Member Member { get { return DataCenter.RequestAllMembers().SingleOrDefault(m => m.Number == MemberNumber); } }
		public Service Service { get { return DataCenter.RequestAllServices().SingleOrDefault(s => s.Code == ServiceCode); } }

		public Record()
		{
			CurrentDate = "";
			ServiceDate = "";
			ProviderNumber = "";
			MemberNumber = "";
			ServiceCode = "";
			Comments = "";
			Fee = 0;
		}

		public Record(string currentDate, string serviceDate, string providerNumber, string memberNumber, string serviceCode, string comments, float fee)
		{
			CurrentDate = currentDate;
			ServiceDate = serviceDate;
			ProviderNumber = providerNumber;
			MemberNumber = memberNumber;
			ServiceCode = serviceCode;
			Comments = comments;
			Fee = fee;
		}

		public void Save(XElement parentNode)
		{
			parentNode.Add(
				new XElement("CurrentDate", CurrentDate),
				new XElement("ServiceDate", ServiceDate),
				new XElement("ProviderNumber", ProviderNumber),
				new XElement("MemberNumber", MemberNumber),
				new XElement("ServiceCode", ServiceCode),
				new XElement("Comments", Comments),
				new XElement("Fee", Fee));
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
					case "Fee":
						Fee = float.Parse(iChild.Value);
						break;
				}
			}
		}
	}
}
