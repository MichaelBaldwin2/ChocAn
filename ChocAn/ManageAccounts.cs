using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAn
{
    /**
     * ManageAccounts: Main controller class for OperatorTerminal. Lets operator add, update, and delete
     * members and providers in the database.
     */
    class ManageAccounts
    {
        public static MemberAccounts ma = new MemberAccounts();
        public static ProviderAccounts pacc = new ProviderAccounts();
        /**
         * add new member to the database
         */

        public static bool addMember(string name, int number, string address, string city, string state, int zip)
        {
            List<MemberAccounts> members = DirectoryDB.ReadMember();
            bool flag = false;
            ma.setName(name);

            string temp = number.ToString();

            int exists = validMember(number);
            if(exists == 1)
            {
                MessageBox.Show("The member number already exists!", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (temp.Length != 9)
            {
                MessageBox.Show("The member number must be 9 digits long!", "Chech Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ma.setNumber(number);
            ma.setAddress(address);
            ma.setCity(city);
            ma.setState(state);
            ma.setZipCode(zip);
            ma.setStatus(true);

            members.Add(ma);
            printMember(members);
            flag = true;

            return flag;
        }

        /**
         * delete a member from the database
         */
         public static void deleteMember(int number)
        {
            List<MemberAccounts> members = DirectoryDB.ReadMember();
            int found = -1;
            string temp = number.ToString();

            if(temp.Length != 9)
            {
                MessageBox.Show("The member number must be 9 digits long!", "Chech Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach(MemberAccounts m in members)
            {
                if (m.getNumber() == number)
                {
                    members.Remove(m);
                    found = 1;
                    break;
                }
            }

            if(found == -1)
            {
                MessageBox.Show("The member does not exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            printMember(members);
        }

        /**
         * update an existing member's information
         */
         public static int updateMemebr(string name, int number, string address, string city, string state, int zip)
        {
            List<MemberAccounts> members = DirectoryDB.ReadMember();
            string zipCode = zip.ToString();
            string numberStr = number.ToString();
            int output = 0;

            if (name.Equals("") || address.Equals("") || city.Equals("") || state.Equals(""))
            {
                output = -1;
                MessageBox.Show("Input fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(zipCode.Length != 5)
            {
                output = -2;
                MessageBox.Show("Zip code must be 5 digits long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(numberStr.Length != 9)
            {
                MessageBox.Show("Member number must be 9 digits long!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach(MemberAccounts m in members)
            {
                if (m.getNumber() == number)
                {
                    m.setName(name);
                    m.setNumber(m.getNumber());
                    m.setAddress(address);
                    m.setCity(city);
                    m.setState(state);
                    m.setZipCode(zip);
                }
            }
            printMember(members);
            return output;
        }

        /**
         * print the provided list of members
         */

        public static void printMember(List<MemberAccounts> ma)
        {
            string fileName = "member.txt";
            string fullPath = Path.Combine(Environment.CurrentDirectory + @"\Database\", fileName);

            using (StreamWriter input = new StreamWriter(fullPath))
            {
                try
                {
                    foreach(MemberAccounts member in ma)
                    {
                        input.Write(member.getName() + "," + member.getNumber() + "," + member.getAddress() + "," + member.getCity() + "," + 
                            member.getState() + "," + member.getZipCode() + "," + member.getStatus() + "\n");
                        List<ServiceRecord> sr = member.getServicesProvided();
                        if(sr != null)
                        {
                            foreach(ServiceRecord service in sr)
                            {
                                input.Write("s," + service.getCurrentDateTime() + "," + service.getDateOfService() + ","
                                + service.getProviderNumber() + "," + service.getMemberNumber() + "," + service
                                .getServiceCode() + "," + service.getComments() + "\n");
                            }
                        }
                    }
                    input.Close();
                }
                catch(FileNotFoundException ex)
                {
                    MessageBox.Show("Error: File not found", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /**
         * verify if a specific member exists in the database
         */

        public static int validMember(int number)
        {
            List<MemberAccounts> members = DirectoryDB.ReadMember();

            int found = 0;
            foreach(MemberAccounts m in members)
            {
                if (m.getNumber() == number)
                {
                    found = 1;
                    break;
                }
            }
            return found;
        }


        /**
         * add a new provider to the database
         */
         public static bool addProvider(string name, int number, string address, string city, string state, int zip)
        {
            List<ProviderAccounts> providers = DirectoryDB.ReadProviders();
            bool flag = false;

            string pn = number.ToString();

            int exists = validProvider(number);
            if(exists == 1)
            {
                MessageBox.Show("The provider number already exists!", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(pn.Length != 9)
            {
                MessageBox.Show("The member number must be 9 digits long!", "Chech Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pacc.setName(name);
            pacc.setNumber(number);
            pacc.setAddress(address);
            pacc.setCity(city);
            pacc.setState(state);
            pacc.setZipCode(zip);

            providers.Add(pacc);
            printProviders(providers);
            flag = true;

            return flag;
        }

        /**
         * delete a provider from the database
         */
         public static void deleteProvider(int number)
        {
            List<ProviderAccounts> providers = DirectoryDB.ReadProviders();

            int found = -1;
            foreach(ProviderAccounts p in providers)
            {
                if(p.getNumber() == number)
                {
                    providers.Remove(p);
                    found = 1;
                    break;
                }
            }

            if(found == -1)
            {
                MessageBox.Show("The provider does not exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            printProviders(providers);
        }

        /**
         * update a specific provider's info
         */
         public static int updateProvider(string name, int number, string address, string city, string state, int zip)
        {
            List<ProviderAccounts> providers = DirectoryDB.ReadProviders();
            string zipCode = zip.ToString();
            string numberStr = number.ToString();
            int output = 0;

            if (name.Equals("") || address.Equals("") || city.Equals("") || state.Equals(""))
            {
                output = -1;
                MessageBox.Show("Input fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (zipCode.Length != 5)
            {
                output = -2;
                MessageBox.Show("Zip code must be 5 digits long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numberStr.Length != 9)
            {
                MessageBox.Show("Provider number must be 9 digits long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (ProviderAccounts p in providers)
            {
                if (p.getNumber() == number)
                {
                    p.setName(name);
                    p.setNumber(p.getNumber());
                    p.setAddress(address);
                    p.setCity(city);
                    p.setState(state);
                    p.setZipCode(zip);
                }
            }
            printProviders(providers);
            return output;
        }

        /**
         * verifies if a provider exists in the directory or not
         */
         public static int validProvider(int number)
        {
            List<ProviderAccounts> providers = DirectoryDB.ReadProviders();

            int found = 0;
            foreach(ProviderAccounts p in providers)
            {
                if (p.getNumber() == number)
                {
                    found = 1;
                    break;
                }
            }
            return found;
        }


        /**
         * prints the list of providers and the corresponding service records
         */
         public static void printProviders(List<ProviderAccounts> pa)
        {
            string fileName = "provider.txt";
            string fullPath = Path.Combine(Environment.CurrentDirectory + @"\Database\", fileName);

            using(StreamWriter input = new StreamWriter(fullPath))
            {
                try
                {
                    foreach(ProviderAccounts provider in pa)
                    {
                        input.Write(provider.getName() + "," + provider.getNumber() + "," + provider.getAddress() + ","
                                    + provider.getCity() + "," + provider.getState() + "," + provider.getZipCode()
                                    + "\n");

                        List<ServiceRecord> sr = provider.getServicesProvided();
                        if(sr != null)
                        {
                            foreach(ServiceRecord service in sr)
                            {
                                input.Write("s," + service.getCurrentDateTime() + "," + service.getDateOfService() + ","
                                            + service.getProviderNumber() + "," + service.getMemberNumber() + "," + service
                                            .getServiceCode() + "," + service.getComments() + "\n");
                            }
                        }
                    }
                    input.Close();
                }
                catch(FileNotFoundException ex)
                {
                    MessageBox.Show("Error: File not found", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /**
         * find a member by member number in the database
         */

        public static MemberAccounts findMember(int memNum)
        {
            List<MemberAccounts> me = DirectoryDB.ReadMember();
            MemberAccounts ma = new MemberAccounts();

            foreach (MemberAccounts account in me)
            {
                if (account.getNumber() == memNum)
                {
                    ma = account;
                }
            }
            return ma;
        }

        public static ProviderAccounts findProvider(int proNum)
        {
            List<ProviderAccounts> lpa = DirectoryDB.ReadProviders();
            ProviderAccounts pa = new ProviderAccounts();

            foreach(ProviderAccounts account in lpa)
            {
                if (account.getNumber() == proNum)
                {
                    pa = account;
                }
            }
            return pa;
        }
    }
}
