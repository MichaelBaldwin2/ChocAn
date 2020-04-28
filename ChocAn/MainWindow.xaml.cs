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

		//===== MAIN PANEL =====\\

		private void btnProviderProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			ProviderLoginPanel.Visibility = Visibility.Visible;
		}

		private void btnManagerProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			ManagerLoginPanel.Visibility = Visibility.Visible;
		}

		//===== PROVIDER =====\\

		private void btnProviderLogin_Click(object sender, RoutedEventArgs e)
		{
			var providerNumber = inProviderID.Text;
			var isProviderID = !numOnlyRegex.IsMatch(providerNumber);

			if (!isProviderID)
			{
				lblProviderInputError.Content = "Provider ID must be numerical!";
				return;
			}

			// Now we check if the provider ID even exists in the DataBase
			try
			{
				var provider = dataCenter.GetProviderInfo(providerNumber);
			}
			catch(ProviderNotFoundException exc)
			{
				lblProviderInputError.Content = exc.Message;
			}
		}

		private void btnProviderBack_Click(object sender, RoutedEventArgs e)
		{
			ProviderPanel.Visibility = Visibility.Hidden;
			ProfessionPanel.Visibility = Visibility.Visible;
		}

		//===== MANAGER =====\\

		private void btnManagerLogin_Click(object sender, RoutedEventArgs e)
		{
			var managerID = inManagerID.Text;
			var isManagerID = !numOnlyRegex.IsMatch(managerID);

			if (!isManagerID)
			{
				lblManagerInputError.Content = "Manager ID must be numerical!";
				return;
			}

			// We only have a single manager login (Hint: It's '0000')
			if(managerID != "0000")
			{
				lblManagerInputError.Content = "Incorrect manager ID (Hint: It's '0000')";
				return;
			}

			ManagerLoginPanel.Visibility = Visibility.Hidden;
			ManagerPanel.Visibility = Visibility.Visible;
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

		private void btnManagerBack_Click(object sender, RoutedEventArgs e)
		{
			ManagerPanel.Visibility = Visibility.Hidden;
			ProfessionPanel.Visibility = Visibility.Visible;
		}

		private void btnMemberProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			MemberLoginPanel.Visibility = Visibility.Visible;
		}

		private void btnOperatorProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProfessionPanel.Visibility = Visibility.Hidden;
			OperatorLoginPanel.Visibility = Visibility.Visible;
		}

		private void btnBackToMain_Click(object sender, RoutedEventArgs e)
		{
			MemberLoginPanel.Visibility		= Visibility.Hidden;
			ProviderLoginPanel.Visibility	= Visibility.Hidden;
			ManagerLoginPanel.Visibility	= Visibility.Hidden;
			OperatorLoginPanel.Visibility	= Visibility.Hidden;
			ProfessionPanel.Visibility		= Visibility.Visible;
		}

		private void btnMemberLogin_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnOperatorLogin_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
