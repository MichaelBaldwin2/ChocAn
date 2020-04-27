using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChocAn
{
	public class Provider
	{
		public string Name { get; private set; }
		public string Number { get; private set; }
		public string Address { get; private set; }
		public string City { get; private set; }
		public string State { get; private set; }
		public string Zip { get; private set; }

		public Provider()
		{
			Name = "";
			Number = "";
			Address = "";
			City = "";
			State = "";
			Zip = "";
		}

		public Provider(string name, string number, string address, string city, string state, string zip)
		{
			Name = name;
			Number = number;
			Address = address;
			City = city;
			State = state;
			Zip = zip;
		}

		public void Save(XElement parentNode)
		{
			parentNode.Add(
				new XElement("Name", Name),
				new XElement("Number", Number),
				new XElement("Address", Address),
				new XElement("City", City),
				new XElement("State", State),
				new XElement("Zip", Zip));
		}

		public void Load(XElement parentNode)
		{
			foreach(var iChild in parentNode.Elements())
			{
				switch(iChild.Name.ToString())
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
				}
			}
		}
	}
}
