using System.Xml.Linq;

namespace ChocAn
{
	public class Member
	{
		public string Name { get; private set; }
		public string Number { get; private set; }
		public string Address { get; private set; }
		public string City { get; private set; }
		public string State { get; private set; }
		public string Zip { get; private set; }
		public bool Enabled { get; private set; }

		public Member()
		{
			Name = "";
			Number = "";
			Address = "";
			City = "";
			State = "";
			Zip = "";
			Enabled = true;
		}

		public Member(string name, string number, string address, string city, string state, string zip, bool enabled)
		{
			Name = name;
			Number = number;
			Address = address;
			City = city;
			State = state;
			Zip = zip;
			Enabled = enabled;
		}

		public void Save(XElement parentNode)
		{
			parentNode.Add(
				new XElement("Name", Name),
				new XElement("Number", Number),
				new XElement("Address", Address),
				new XElement("City", City),
				new XElement("State", State),
				new XElement("Zip", Zip),
				new XElement("Enabled", Enabled));
		}

		public void Load(XElement parentNode)
		{
			foreach (var iChild in parentNode.Elements())
			{
				switch (iChild.Name.ToString())
				{
					case "Name":
						Name = iChild.Value;
						break;
					case "Number":
						Number = iChild.Value;
						break;
					case "Address":
						Address = iChild.Value;
						break;
					case "City":
						City = iChild.Value;
						break;
					case "State":
						State = iChild.Value;
						break;
					case "Zip":
						Zip = iChild.Value;
						break;
					case "Enabled":
						Enabled = bool.Parse(iChild.Value);
						break;
				}
			}
		}
	}
}
