using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ChocAn
{
	public class ChocAnDataCenter
	{
		public DBFile dbFile;

		public ChocAnDataCenter(string filePath)
		{
			dbFile = new DBFile(filePath);
		}

		public void AddNewProvider(Provider provider)
		{
			dbFile.Write(provider);
		}

		public void AddNewMember(Member member)
		{
			dbFile.Write(member);
		}

		public Provider GetProviderInfo(string providerNumber)
		{
			try
			{
				return dbFile.ReadProvider(providerNumber);
			}
			catch(ProviderNotFoundException exc)
			{
				throw exc;
			}
		}

		public Member GetMemberInfo(string memberNumber)
		{
			try
			{
				return dbFile.ReadMember(memberNumber);
			}
			catch (MemberNotFoundException exc)
			{
				throw exc;
			}
		}

		public void RunMainAccountingProcedure()
		{

		}

		public void SendListOfServices()
		{

		}

		public void SendProviderReports()
		{

		}

		public void GenerateProviderReports()
		{

		}
	}
}
