//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml.Linq;
//using Microsoft.VisualBasic;

//namespace ChocAn
//{
//    class BillChocAn
//    {
//        /**
//         * billCochAn, allows the provider to bill chocan after a service has been provided and updates both member and provider database
//         */
//         public static void billChocAn(string currentDate, string actDate, int providerNum, int serviceCode, int memberNum)
//        {
//            List<MemberAccounts> me = DirectoryDB.ReadMember();
//            List<ProviderAccounts> pa = DirectoryDB.ReadProviders();
//            List<ProviderDirectoryEntry> pde = DirectoryDB.ReadProviderDirectoryEntry();
//            ServiceRecord sr = new ServiceRecord();

//            MemberAccounts found = ManageAccounts.findMember(memberNum);
//            ProviderAccounts providerFound = ManageAccounts.findProvider(providerNum);

//            if(found.getStatus() == false)
//            {
//                return;
//            }

//            sr.setCurrentDateTime(currentDate);

//            sr.setDateOfService(actDate);
//            sr.setProviderNumber(providerNum);
//            sr.setMemberNumber(memberNum);
//            string ProviderDir = "";
//            foreach(ProviderDirectoryEntry pd in pde)
//            {
//                ProviderDir += pd.getServiceName() + "," + pd.getServiceCode() + "," + pd.getServiceFee() + "\n";
//            }
//            ProviderDirectoryEntry valid = ProviderDirectory.validEntry(serviceCode);
//            if(valid == null)
//            {
//                return;
//            }

//            var confirm = MessageBox.Show("The total fee for the service " + valid.getServiceName() + " is $" + valid.getServiceFee() + " Would you like to continue?", "Fees", MessageBoxButtons.YesNo);

//            if (confirm == DialogResult.No)
//            {
//                return;
//            }
//            else if(confirm == DialogResult.Yes)
//            {
//                sr.setServiceCode(serviceCode);

//                string comment = 
//            }
//        }
//    }
//}
