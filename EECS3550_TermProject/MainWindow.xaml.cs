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

namespace EECS3550_TermProject
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
		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
			var providerID = inProviderID.Text;
			var isProviderID = numOnlyRegex.IsMatch(providerID);

			if(isProviderID)
			{
				lblInputError.Visibility = Visibility.Visible;
			}
			else // Wrong ID
			{
				lblInputError.Visibility = Visibility.Hidden;
			}
		}
	}
}
