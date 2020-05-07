using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChocAn
{
    /// <summary>
    /// Interaction logic for AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, RoutedEventArgs e)
        {
            Service service = DataCenter.RequestServiceInfoByNumber(inServiceCode.Text);
            Record newRecord = new Record(inCurrentDateTime.Text, inDateServiceProvided.Text, inProviderID.Text, inMemberID.Text, inServiceCode.Text, inComments.Text, service.Fee);
            DataCenter.WriteRecordInfo(newRecord);
            lblServiceAdded.Content = "Service added successfully";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnVerifyService_Click(object sender, RoutedEventArgs e)
        {
            Service service = DataCenter.RequestServiceInfoByNumber(inServiceCode.Text);
            lblServiceCode.Content = service.Code;
            lblServiceName.Content = service.Name;
            lblServiceFee.Content = service.Fee;
        }
    }
}
