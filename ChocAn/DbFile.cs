using System.IO;
using System.Xml.Linq;

namespace ChocAn
{
	public class DBFile
	{
		//"C:/Temp/ChocAnDB.xml"
		public string FilePath { get; }

		public DBFile(string filePath)
		{
			FilePath = filePath;
		}

		public Record ReadRecordByMemberNumber(string memberNumber)
		{
			XDocument xmlDoc;
			if (File.Exists(FilePath))
				xmlDoc = XDocument.Load(FilePath);
			else
				throw new ProviderNotFoundException();

			// Next we need to check if the provider element even exists
			var allRecordsElemParent = xmlDoc.Element("Records");
			if (allRecordsElemParent == null)
				throw new RecordNotFoundException("The Record directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			foreach (var xElem in allRecordsElemParent.Elements())
			{
				var record = new Record();
				record.Load(xElem);
				if (record.MemberNumber == memberNumber)
					return record;
			}

			throw new RecordNotFoundException("That Member Number doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");
		}

		public Record ReadRecordByProviderNumber(string providerNumber)
		{
			XDocument xmlDoc;
			if (File.Exists(FilePath))
				xmlDoc = XDocument.Load(FilePath);
			else
				throw new ProviderNotFoundException();

			// Next we need to check if the provider element even exists
			var allRecordsElemParent = xmlDoc.Element("Records");
			if (allRecordsElemParent == null)
				throw new RecordNotFoundException("The Record directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			foreach (var xElem in allRecordsElemParent.Elements())
			{
				var record = new Record();
				record.Load(xElem);
				if (record.ProviderNumber == providerNumber)
					return record;
			}

			throw new RecordNotFoundException("That Member Number doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");
		}

		public Provider ReadProvider(string providerNumber)
		{
			XDocument xmlDoc;
			if (File.Exists(FilePath))
				xmlDoc = XDocument.Load(FilePath);
			else
				throw new ProviderNotFoundException();

			// Next we need to check if the provider element even exists
			var allProviderElemParent = xmlDoc.Element("Providers");
			if(allProviderElemParent == null)
				throw new ProviderNotFoundException("Provider directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			foreach (var xElem in allProviderElemParent.Elements())
			{
				var provider = new Provider();
				provider.Load(xElem);
				if (provider.Number == providerNumber)
					return provider;
			}

			throw new ProviderNotFoundException("That Provider Number doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");
		}

		public Member ReadMember(string memberNumber)
		{
			XDocument xmlDoc;
			if (File.Exists(FilePath))
				xmlDoc = XDocument.Load(FilePath);
			else
				throw new ProviderNotFoundException();

			// Next we need to check if the provider element even exists
			var allMembersElemParent = xmlDoc.Element("Members");
			if (allMembersElemParent == null)
				throw new MemberNotFoundException("Member directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			foreach (var xElem in allMembersElemParent.Elements())
			{
				var member = new Member();
				member.Load(xElem);
				if (member.Number == memberNumber)
					return member;
			}

			throw new MemberNotFoundException("That Member Number doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");
		}

		public void Write(Record record)
		{
			// Either create or load the db file
			var xmlDoc = new XDocument(new XElement("ChocAn"));
			if (File.Exists(FilePath))
				xmlDoc = XDocument.Load(FilePath);

			// Either load or create the providers XElement
			var parentElem = xmlDoc.Root.Element("Records");
			if (parentElem == null)
			{
				parentElem = new XElement("Records");
				xmlDoc.Root.Add(parentElem);
			}

			// Add the new provider element to the existing provider elements
			var newElem = new XElement("Record");
			record.Save(newElem);
			parentElem.Add(newElem);

			// Save the modified XDocument
			xmlDoc.Save(FilePath);
		}

		public void Write(Provider provider)
		{
			// Either create or load the db file
			var xmlDoc = new XDocument(new XElement("ChocAn"));
			if (File.Exists(FilePath))
				xmlDoc = XDocument.Load(FilePath);

			// Either load or create the providers XElement
			var parentElem = xmlDoc.Root.Element("Providers");
			if (parentElem == null)
			{
				parentElem = new XElement("Providers");
				xmlDoc.Root.Add(parentElem);
			}

			// Add the new provider element to the existing provider elements
			var newElem = new XElement("Provider");
			provider.Save(newElem);
			parentElem.Add(newElem);

			// Save the modified XDocument
			xmlDoc.Save(FilePath);
		}

		public void Write(Member member)
		{
			// Either create or load the db file
			var xmlDoc = new XDocument(new XElement("ChocAn"));
			if (File.Exists(FilePath))
				xmlDoc = XDocument.Load(FilePath);

			// Either load or create the providers XElement
			var parentElem = xmlDoc.Root.Element("Members");
			if (parentElem == null)
			{
				parentElem = new XElement("Members");
				xmlDoc.Root.Add(parentElem);
			}

			// Add the new provider element to the existing provider elements
			var newElem = new XElement("Member");
			member.Save(newElem);
			parentElem.Add(newElem);

			// Save the modified XDocument
			xmlDoc.Save(FilePath);
		}
	}
}
