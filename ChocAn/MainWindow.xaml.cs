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
		public MainWindow()
		{
			InitializeComponent();
			DataCenter.Open("ChocAnDB.xml");
		}
		
		private void btnMemberProLogin_Click(object sender, RoutedEventArgs e)
		{
			MemberLogin memberLoginWindow = new MemberLogin();
			memberLoginWindow.Show();
			this.Close();
		}
		
		private void btnManagerProLogin_Click(object sender, RoutedEventArgs e)
		{
			ManagerLogin managerLoginWindow = new ManagerLogin();
			managerLoginWindow.Show();
			this.Close();
		}

		private void btnOperatorProLogin_Click(object sender, RoutedEventArgs e)
		{
			OperatorLogin operatorLoginWindow = new OperatorLogin();
			operatorLoginWindow.Show();
			this.Close();
		}

		private void btnProviderProLogin_Click(object sender, RoutedEventArgs e)
		{
			ProviderLogin providerLoginWindow = new ProviderLogin();
			providerLoginWindow.Show();
			this.Close();
		}

	}
}
