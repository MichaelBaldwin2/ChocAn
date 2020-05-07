﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace ChocAn
{
	public static class DataCenter
	{
		public static string FilePath { get; private set; }
		public static XDocument XDoc { get; private set; }

		/// <summary>
		/// Constructor that takes in a database file path string
		/// </summary>
		/// <param name="filePath">The file path, including extension</param>
		public static bool Open(string filePath)
		{
			FilePath = filePath;

			if (!File.Exists(FilePath))
			{
				MessageBox.Show("DataBase file was not found at: " + filePath);
				return false;
			}

			XDoc = XDocument.Load(FilePath);
			return true;
		}

		/// <summary>
		/// Gets all the records that have this member in them.
		/// </summary>
		/// <param name="memberNumber">The member number to search for</param>
		/// <returns>A list of records, or null</returns>
		public static List<Record> RequestAllRecordsFromMember(string memberNumber)
		{
			return RequestAllRecords().Where(r => r.MemberNumber == memberNumber).ToList();
		}

		/// <summary>
		/// Gets all the records that have this provider in them.
		/// </summary>
		/// <param name="memberNumber">The provider number to search for</param>
		/// <returns>A list of records, or null</returns>
		public static List<Record> RequestAllRecordsFromProvider(string providerNumber)
		{
			return RequestAllRecords().Where(r => r.ProviderNumber == providerNumber).ToList();
		}

		/// <summary>
		/// Requests provider information
		/// </summary>
		/// <param name="providerNumber">The provider number to search for</param>
		/// <returns>A provider if found, or null if not found</returns>
		public static Provider RequestProviderInfo(string providerNumber)
		{
			return RequestAllProviders().Single(p => p.Number == providerNumber);
		}

		/// <summary>
		/// Requests member information
		/// </summary>
		/// <param name="memberNumber">The member number to search for</param>
		/// <returns>A member if found, or null if not found</returns>
		public static Member RequestMemberInfo(string memberNumber)
		{
			return RequestAllMembers().Single(m => m.Number == memberNumber);
		}

		/// <summary>
		/// Requests service information
		/// </summary>
		/// <param name="memberNumber">The service number to search for</param>
		/// <returns>A service if found, or null if not found</returns>
		public static Service RequestServiceInfoByNumber(string serviceCode)
		{
			return RequestAllServices().Single(s => s.Code == serviceCode);
		}

		/// <summary>
		/// Requests service information
		/// </summary>
		/// <param name="memberNumber">The service number to search for</param>
		/// <returns>A service if found, or null if not found</returns>
		public static Service RequestServiceInfoByName(string serviceName)
		{
			return RequestAllServices().Single(s => s.Code == serviceName);
		}

		/// <summary>
		/// Request all the records from the database
		/// </summary>
		/// <returns>A list of records</returns>
		public static List<Record> RequestAllRecords()
		{
			var allElems = XDoc.Root.Element("Records");
			if (allElems == null)
				throw new RecordNotFoundException("The Record directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			var allRecords = new List<Record>(allElems.Elements().Count());
			foreach (var xElem in allElems.Elements())
			{
				var record = new Record();
				record.Load(xElem);
				allRecords.Add(record);
			}
			return allRecords;
		}

		/// <summary>
		/// Request all the providers from the database
		/// </summary>
		/// <returns>A list of providers</returns>
		public static List<Provider> RequestAllProviders()
		{
			var allElems = XDoc.Root.Element("Providers");
			if (allElems == null)
				throw new ProviderNotFoundException("The provider directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			var allRecords = new List<Provider>(allElems.Elements().Count());
			foreach (var xElem in allElems.Elements())
			{
				var record = new Provider();
				record.Load(xElem);
				allRecords.Add(record);
			}
			return allRecords;
		}

		/// <summary>
		/// Request all the members from the database
		/// </summary>
		/// <returns>A list of members</returns>
		public static List<Member> RequestAllMembers()
		{
			var allElems = XDoc.Root.Element("Members");
			if (allElems == null)
				throw new ProviderNotFoundException("The member directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			var allRecords = new List<Member>(allElems.Elements().Count());
			foreach (var xElem in allElems.Elements())
			{
				var record = new Member();
				record.Load(xElem);
				allRecords.Add(record);
			}
			return allRecords;
		}

		/// <summary>
		/// Request all the members from the database
		/// </summary>
		/// <returns>A list of members</returns>
		public static List<Service> RequestAllServices()
		{
			var allElems = XDoc.Root.Element("Services");
			if (allElems == null)
				throw new ProviderNotFoundException("The service directory doesn't exist in the ChocAn DataBase. Please contact your system administrator to fix this!");

			var allRecords = new List<Service>(allElems.Elements().Count());
			foreach (var xElem in allElems.Elements())
			{
				var record = new Service();
				record.Load(xElem);
				allRecords.Add(record);
			}
			return allRecords;
		}

		/// <summary>
		/// Write a new record to the database
		/// </summary>
		/// <param name="record">The record to write</param>
		public static void WriteRecordInfo(Record record)
		{
			var parentElem = XDoc.Root.Element("Records");
			if (parentElem == null)
			{
				parentElem = new XElement("Records");
				XDoc.Root.Add(parentElem);
			}

			var newElem = new XElement("Record");
			record.Save(newElem);
			parentElem.Add(newElem);
			XDoc.Save(FilePath);
		}

		/// <summary>
		/// Write a new provider to the database
		/// </summary>
		/// <param name="provider">The provider to write</param>
		public static void WriteProviderInfo(Provider provider)
		{
			var parentElem = XDoc.Root.Element("Providers");
			if (parentElem == null)
			{
				parentElem = new XElement("Providers");
				XDoc.Root.Add(parentElem);
			}

			var newElem = new XElement("Provider");
			provider.Save(newElem);
			parentElem.Add(newElem);
			XDoc.Save(FilePath);
		}

		/// <summary>
		/// Write a new member to the database
		/// </summary>
		/// <param name="member">The member to write</param>
		public static void WriteMemberInfo(Member member)
		{
			var parentElem = XDoc.Root.Element("Members");
			if (parentElem == null)
			{
				parentElem = new XElement("Members");
				XDoc.Root.Add(parentElem);
			}

			var newElem = new XElement("Member");
			member.Save(newElem);
			parentElem.Add(newElem);
			XDoc.Save(FilePath);
		}

		public static void RunMainAccountingProcedure()
		{

		}

		public static void SendListOfServices()
		{

		}

		public static void SendProviderReports()
		{

		}

		public static void GenerateProviderReports()
		{

		}
	}
}
