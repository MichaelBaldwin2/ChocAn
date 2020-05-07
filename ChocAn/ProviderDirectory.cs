using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAn
{
    class ProviderDirectory
    {
        public ProviderDirectory()
        {

        }

        /**
         * validEntry() takes in the service code and returns the provider directory entry if it exists in the database
         */
         public static ProviderDirectoryEntry validEntry(int code)
        {
            List<ProviderDirectoryEntry> pde = DirectoryDB.ReadProviderDirectoryEntry();
            ProviderDirectoryEntry entry = new ProviderDirectoryEntry();
            string temp = code.ToString();
            if(temp.Length != 6)
            {
                MessageBox.Show("The service code must be 6 digits long!", "Service Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach(ProviderDirectoryEntry pd in pde)
            {
                if (pd.getServiceCode() == code)
                {
                    entry = pd;
                }
            }
            return entry;
        }

        /**
         * findEntry() takes in the service code and returns a boolean if the providerDirectoryEntry exists
         */
         public static bool findEntry(int code)
        {
            List<ProviderDirectoryEntry> pde = DirectoryDB.ReadProviderDirectoryEntry();
            ProviderDirectoryEntry entry = new ProviderDirectoryEntry();
            bool flag = false;
            foreach(ProviderDirectoryEntry pd in pde)
            {
                if (pd.getServiceCode() == code)
                {
                    entry = pd;
                    flag = true;
                }
            }
            return flag;
        }
    }
}
