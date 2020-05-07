using System.Xml.Linq;

namespace ChocAn
{
	/// <summary>
	/// Provider class representing the provider
	/// </summary>
	public class Provider
	{
		public string Name { get; private set; }
		public string Number { get; private set; }
		public string Address { get; private set; }
		public string City { get; private set; }
		public string State { get; private set; }
		public string Zip { get; private set; }
		public bool Enabled { get; private set; }

		/// <summary>
		/// Default constructor. Needed for deserialization.
		/// </summary>
		public Provider()
		{
			Name = "";
			Number = "";
			Address = "";
			City = "";
			State = "";
			Zip = "";
			Enabled = true;
		}

		/// <summary>
		/// Constructor taking in property values.
		/// </summary>
		public Provider(string name, string number, string address, string city, string state, string zip, bool enabled)
		{
			Name = name;
			Number = number;
			Address = address;
			City = city;
			State = state;
			Zip = zip;
			Enabled = enabled;
		}

		/// <summary>
		/// Save this providers information to the database
		/// </summary>
		/// <param name="parentNode">THe XElement node to write under</param>
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

		/// <summary>
		/// Load this providers information from the database.
		/// </summary>
		/// <param name="parentNode">The XElement node to read from</param>
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
					case "Enabled":
						Enabled = bool.Parse(iChild.Value);
						break;
				}
			}
		}
	}
}
