using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace ChocAn
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Regex numOnlyRegex = new Regex("[^0-9.-]+");

		public MainWindow()
		{
			InitializeComponent();
			DataCenter.Open("ChocAnDB.xml");
		}

		private void btnProviderProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			ProviderLoginPanel.Visibility = Visibility.Visible;
		}
		private void btnProviderLogin_Click(object sender, RoutedEventArgs e)
		{
			var providerNumber = inProviderID.Password;
			var isProviderID = !numOnlyRegex.IsMatch(providerNumber);

			if (!isProviderID)
			{
				lblProviderIDInputError.Content = "Provider ID must be numerical!";
				return;
			}

			// We only have a single operator login (Hint: It's '0000')
			if (providerNumber != "0000")
			{
				lblProviderIDInputError.Content = "Incorrect Manager ID (Hint: It's '0000')";
				return;
			}

			ProviderLoginPanel.Visibility = Visibility.Hidden;
			ProviderPanel.Visibility = Visibility.Visible;

			//// Check if Provider ID exists in database
			//try
			//{
			//	var provider = dataCenter.GetProviderInfo(providerNumber);
			//}
			//catch (ProviderNotFoundException exc)
			//{
			//	lblProviderIDInputError.Content = exc.Message;
			//}
		}

		private void btnManagerProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			ManagerLoginPanel.Visibility = Visibility.Visible;
		}
		private void btnManagerLogin_Click(object sender, RoutedEventArgs e)
		{
			var managerID = inManagerID.Password;
			var isManagerID = !numOnlyRegex.IsMatch(managerID);

			if (!isManagerID)
			{
				lblManagerIDInputError.Content = "Manager ID must be numerical!";
				return;
			}

			// We only have a single operator login (Hint: It's '0000')
			if (managerID != "0000")
			{
				lblManagerIDInputError.Content = "Incorrect Manager ID (Hint: It's '0000')";
				return;
			}

			ManagerLoginPanel.Visibility = Visibility.Hidden;
			ManagerPanel.Visibility = Visibility.Visible;
		}

		private void btnOperatorProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			OperatorLoginPanel.Visibility = Visibility.Visible;
		}
		private void btnOperatorLogin_Click(object sender, RoutedEventArgs e)
		{
			var operatorID = inOperatorID.Password;
			var isOperatorID = !numOnlyRegex.IsMatch(operatorID);

			if (!isOperatorID)
			{
				lblOperatorIDInputError.Content = "Operator ID must be numerical!";
				return;
			}

			// We only have a single operator login (Hint: It's '0000')
			if(operatorID != "0000")
			{
				lblOperatorIDInputError.Content = "Incorrect Operator ID (Hint: It's '0000')";
				return;
			}

			OperatorLoginPanel.Visibility = Visibility.Hidden;
			OperatorPanel.Visibility = Visibility.Visible;
		}
		private void btnNewProvider_Click(object sender, RoutedEventArgs e)
		{
			// Check all the inputs
			var provider = new Provider(inProviderName.Text, inProviderNumber.Text, inProviderAddress.Text, inProviderCity.Text, inProviderState.Text, inProviderZip.Text, true);
			DataCenter.WriteProviderInfo(provider);
		}

		private void btnNewMember_Click(object sender, RoutedEventArgs e)
		{
			// Check all the inputs
			var member = new Member(inMemberName.Text, inMemberNumber.Text, inMemberAddress.Text, inMemberCity.Text, inMemberState.Text, inMemberZip.Text, true);
			DataCenter.WriteMemberInfo(member);
		}

		private void btnMemberProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			MemberLoginPanel.Visibility = Visibility.Visible;
		}
		private void btnMemberLogin_Click(object sender, RoutedEventArgs e)
		{
			var memberID = inMemberID.Password;
			var isMemberID = !numOnlyRegex.IsMatch(memberID);

			if (!isMemberID)
			{
				lblOperatorIDInputError.Content = "Operator ID must be numerical!";
				return;
			}

			// We only have a single operator login (Hint: It's '0000')
			if (memberID != "0000")
			{
				lblOperatorIDInputError.Content = "Incorrect Operator ID (Hint: It's '0000')";
				return;
			}

			MemberLoginPanel.Visibility = Visibility.Hidden;
			MemberPanel.Visibility = Visibility.Visible;
		}

		private void btnBackToMain_Click(object sender, RoutedEventArgs e)
		{
			MemberLoginPanel.Visibility		= Visibility.Hidden;
			ProviderLoginPanel.Visibility	= Visibility.Hidden;
			ManagerLoginPanel.Visibility	= Visibility.Hidden;
			OperatorLoginPanel.Visibility	= Visibility.Hidden;
			ProfessionPanel.Visibility		= Visibility.Visible;

			ProviderPanel.Visibility			= Visibility.Hidden;
			OperatorPanel.Visibility			= Visibility.Hidden;
			OperatorEditMembersPanel.Visibility = Visibility.Hidden;
			ManagerPanel.Visibility				= Visibility.Hidden;
			MemberPanel.Visibility				= Visibility.Hidden;

			inMemberID.Clear();
			inProviderID.Clear();
			inManagerID.Clear();
			inOperatorID.Clear();
			inManagerID.Clear();
			
		}

		private void btnGenerateSummaryReport_Click(object sender, RoutedEventArgs e) // Generate Summary Report
		{
			GenerateReport.GenerateSummaryReport("SummaryReport.txt");
		}

		private void btnGenerateMemberReport_Click(object sender, RoutedEventArgs e)
		{
			//GenerateReport.generateMemberReport();
		}

		private void btnGenerateProviderReport_Click(object sender, RoutedEventArgs e)
		{
			//GenerateReport.generateProviderReport();
		}

		private void btnGenerateAllMemberReports_Click(object sender, RoutedEventArgs e)
		{
			GenerateReport.GenerateAllMemberReports();
		}

		private void btnGenerateAllProviderReports_Click(object sender, RoutedEventArgs e)
		{
			GenerateReport.GenerateAllProviderReports();
		}

		private void btnValidateMember_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnBillChocAn_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnProviderDirectory_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnMemberPayDues_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnMemberPayService_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnOperatorEditMembers_Click(object sender, RoutedEventArgs e)
		{
			OperatorEditMembersPanel.Visibility = Visibility.Visible;
			OperatorPanel.Visibility = Visibility.Hidden;
		}
		
		private void btnOperatorRunAccountingProcedure_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnRunServicesReport_Click(object sender, RoutedEventArgs e)
		{
		}
	}
}
