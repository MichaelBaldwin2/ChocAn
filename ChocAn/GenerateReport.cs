using System;
using System.IO;
using System.Linq;

namespace ChocAn
{
	public static class GenerateReport
	{
		/// <summary>
		/// Will generate a summary report for the total number of providers, total number of consultations, total number of fees
		/// </summary>
		/// <param name="name">Name of the report</param>
		public static void GenerateSummaryReport(string name)
		{
			var allProviders = DataCenter.RequestAllProviders();

			var fileName = name + ".txt";
			float totalFee = 0;
			int totalConsults = 0;

			using (var output = new StreamWriter(new FileStream(fileName, FileMode.OpenOrCreate)))
			{
				foreach (var iProvider in allProviders)
				{
					var allRecords = DataCenter.RequestAllRecordsFromProvider(iProvider.Number);
					output.WriteLine("Provider Name: " + iProvider.Name + ",");
					if (allRecords == null)
					{
						output.Write(" Number of Consultations: 0" + "," + " Fees: $0\n");
					}
					else
					{
						output.Write(" Number of Consultations: " + allRecords.Count + ",");
						output.Write(" Fees: $" + DataCenter.RequestAllRecordsFromProvider(iProvider.Number).Sum(p => p.Fee) + "\n");
						totalConsults += allRecords.Count;
						totalFee += DataCenter.RequestAllRecordsFromProvider(iProvider.Number).Sum(p => p.Fee);
					}
					output.Write("\n");
					output.Write("Total Number of Providers: " + allProviders.Count() + "\n");
					output.Write("Total Number of Consultations: " + totalConsults + "\n");
					output.Write("Total Number of Fees: $" + totalFee + "\n");
				}
			}
		}

		/// <summary>
		/// Will generate a member report used by the manager
		/// </summary>
		/// <param name="number">The member number</param>
		public static void GenerateMemberReport(string number)
		{
			var member = DataCenter.RequestMemberInfo(number);
			PrintMemberReport(member, member.Name);
		}

		/// <summary>
		/// Will generate a provider report used by the manager
		/// </summary>
		/// <param name="number">The provider number</param>
		public static void GenerateProviderReport(string number)
		{
			var provider = DataCenter.RequestProviderInfo(number);
			PrintProviderReport(provider, provider.Name);
		}

		/// <summary>
		/// Generate a report for all members
		/// </summary>
		public static void GenerateAllMemberReports()
		{
			var allMembers = DataCenter.RequestAllMembers();

			foreach (var iMember in allMembers)
			{
				PrintMemberReport(iMember, iMember.Name);
			}
		}

		/// <summary>
		/// Generate a report for all providers
		/// </summary>
		public static void GenerateAllProviderReports()
		{
			var allProviders = DataCenter.RequestAllProviders();

			foreach (var iProvider in allProviders)
			{
				PrintProviderReport(iProvider, iProvider.Name);
			}
		}

		/// <summary>
		/// Print member report
		/// </summary>
		/// <param name="member">Member object</param>
		/// <param name="name">Name of the report to generate</param>
		public static void PrintMemberReport(Member member, string name)
		{
			name = name.Replace("\\s+", "");
			var filename = name + ".txt";

			using (StreamWriter input = new StreamWriter(new FileStream(filename, FileMode.OpenOrCreate)))
			{
				input.Write("Member Name: " + member.Name + "\n" + "Member Number: " + member.Number + "\n" +
					"Member Address: " + member.Address + "\n" + "Member City: " + member.City +
					"\n" + "Member State: " + member.State + "\n" + "Member Zip Code: " + member.Zip + "\n");

				var allRecords = DataCenter.RequestAllRecordsFromMember(member.Number);
				if (allRecords != null)
				{
					foreach (Record iRecord in allRecords)
					{
						input.Write("\n");
						input.Write("Service Date: " + iRecord.ServiceDate + "\n" + "Service Provider: " + iRecord.ProviderNumber + "\n" + "Service Name: " + iRecord.ServiceCode + "\n");
					}
				}
			}
		}

		/// <summary>
		/// Print the provider report
		/// </summary>
		/// <param name="provider">Provider object</param>
		/// <param name="name">Name of the report to generate</param>
		public static void PrintProviderReport(Provider provider, string name)
		{
			name = name.Replace("\\s+", "");
			double totalFee = 0;
			string filename = name + ".txt";

			using (var output = new StreamWriter(new FileStream(filename, FileMode.OpenOrCreate)))
			{
				output.Write("Provider Name: " + provider.Name + "\n" + "Provider Number: " + provider.Number + "\n" + "Provider Address: " + provider.Address +
					"\n" + "Provider City: " + provider.City + "\n" + "Provider State: " + provider.State + "\n" + "Provider Zip Code: " + provider.Zip + "\n");

				var allRecords = DataCenter.RequestAllRecordsFromProvider(provider.Number);
				if (allRecords != null)
				{
					foreach (var iRecord in allRecords)
					{
						output.Write("\n");
						output.Write("Service Date: " + iRecord.ServiceDate + "\n" + "Date Data Was Received: " + iRecord.CurrentDate +
							"\n" + "Member Name: " + iRecord.Member.Name +
							"\n" + "Member Number: " + iRecord.MemberNumber + "\n" + "Service Code: " + iRecord.ServiceCode +
							"\n" + "Fee to be paid: " + iRecord.Service.Fee + "\n");
						totalFee += iRecord.Service.Fee;
					}
					output.Write("Total number of consultations with members: " + allRecords.Count() + "\n");
					output.Write("Total fees for the week: $" + totalFee + "\n");
				}
				else
				{
					output.Write("Total number of consultations with members: 0\n");
					output.Write("Total fees for the week: $0\n");
				}
			}
		}
	}
}
