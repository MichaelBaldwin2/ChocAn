using System.Xml.Linq;

namespace ChocAn
{
	public class Service
	{
		public string Name { get; private set; }
		public string Code { get; private set; }
		public float Fee { get; private set; }

		public Service()
		{
			Name = "";
			Code = "";
			Fee = 0;
		}

		public Service(string serviceName, string serviceCode, float serviceFee)
		{
			Name = serviceName;
			Code = serviceCode;
			Fee = serviceFee;
		}

		/// <summary>
		/// Save this provider directory information to the database
		/// </summary>
		/// <param name="parentNode">The XElement node to write under</param>
		public void Save(XElement parentNode)
		{
			parentNode.Add(
				new XElement("Name", Name),
				new XElement("Code", Code),
				new XElement("Fee", Fee));
		}

		/// <summary>
		/// Load this provider directory information from the database.
		/// </summary>
		/// <param name="parentNode">The XElement node to read from</param>
		public void Load(XElement parentNode)
		{
			foreach (var iChild in parentNode.Elements())
			{
				switch (iChild.Name.ToString())
				{
					case "Name":
						Name = iChild.Value;
						break;
					case "Code":
						Code = iChild.Value;
						break;
					case "Fee":
						Fee = float.Parse(iChild.Value);
						break;
				}
			}
		}
	}
}
