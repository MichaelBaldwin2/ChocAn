using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChocAn
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Regex numOnlyRegex = new Regex("[^0-9.-]+");
		ChocAnDataCenter dataCenter;

		public MainWindow()
		{
			InitializeComponent();
			dataCenter = new ChocAnDataCenter("C:/Temp/ChocAnDB.xml");
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

			// Check if Provider ID exists in database
			try
			{
				var provider = dataCenter.GetProviderInfo(providerNumber);
			}
			catch (ProviderNotFoundException exc)
			{
				lblProviderIDInputError.Content = exc.Message;
			}
		}

		private void btnManagerProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			ManagerLoginPanel.Visibility = Visibility.Visible;
		}
		private void btnManagerLogin_Click(object sender, RoutedEventArgs e)
		{

		}
		private void btnManagerBack_Click(object sender, RoutedEventArgs e)
		{

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
			var provider = new Provider(inProviderName.Text, inProviderNumber.Text, inProviderAddress.Text, inProviderCity.Text, inProviderState.Text, inProviderZip.Text);
			dataCenter.AddNewProvider(provider);
		}

		private void btnNewMember_Click(object sender, RoutedEventArgs e)
		{
			// Check all the inputs
			var member = new Member(inMemberName.Text, inMemberNumber.Text, inMemberAddress.Text, inMemberCity.Text, inMemberState.Text, inMemberZip.Text);
			dataCenter.AddNewMember(member);
		}

		private void btnMemberProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			MemberLoginPanel.Visibility = Visibility.Visible;
		}
		private void btnMemberLogin_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnBackToMain_Click(object sender, RoutedEventArgs e)
		{
			MemberLoginPanel.Visibility		= Visibility.Hidden;
			ProviderLoginPanel.Visibility	= Visibility.Hidden;
			ManagerLoginPanel.Visibility	= Visibility.Hidden;
			OperatorLoginPanel.Visibility	= Visibility.Hidden;
			ProfessionPanel.Visibility		= Visibility.Visible;

			ProviderPanel.Visibility = Visibility.Hidden;
			OperatorPanel.Visibility = Visibility.Hidden;

			inMemberID.Clear();
			inProviderID.Clear();
			inManagerID.Clear();
			inOperatorID.Clear();
			
		}
		
	}
}
