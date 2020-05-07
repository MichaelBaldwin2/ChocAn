using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAn
{
    class GenerateReport
    {
        /*
         * generateSummaryReport() will generate a summary report for 
         * the total number of providers,
         * total number of consultations,
         * total number of fees
         */
        public static void generateSummaryReport(string name)
        {
            List<ProviderAccounts> providers = DirectoryDB.ReadProviders();

            string fileName = name + ".txt";
            string fullPath = Path.Combine(Environment.CurrentDirectory + @"\writtenFiles\ServiceRecords\", fileName);
            double totalFee = 0;
            int totalConsults = 0;

            using (StreamWriter output = new StreamWriter(fullPath))
            {
                try
                {
                    foreach (ProviderAccounts pa in providers)
                    {
                        List<ServiceRecord> sr = pa.getServicesProvided();
                        output.Write("Provider Name: " + pa.getName() + ",");
                        if (sr == null)
                        {
                            output.Write(" Number of Consultations: 0" + "," + " Fees: $0\n");
                        }
                        else
                        {
                            output.Write(" Number of Consultations: " + pa.getNumberServices() + ",");
                            output.Write(" Fees: $" + pa.getTotalFees(sr) + "\n");
                            totalConsults = totalConsults + pa.getNumberServices();
                            totalFee = totalFee + pa.getTotalFees(sr);
                        }
                    }
                    output.Write("\n");
                    output.Write("Total Number of Providers: " + providers.Count() + "\n");
                    output.Write("Total Number of Consultations: " + totalConsults + "\n");
                    output.Write("Total Number of Fees: $" + totalFee + "\n");
                    output.Close();
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(ObjectDisposedException ex)
                {
                    MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            MessageBox.Show("The summary report was successfully generated and stored in " + name + ".txt","Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*
         * generateMemberReport() will generate a member report used by the manager
         */
        public static void generateMemberReport(int number)
        {
            List<MemberAccounts> members = DirectoryDB.ReadMember();

            foreach (MemberAccounts ma in members)
            {
                if (ma.getNumber() == number)
                {
                    printMemberReport(ma, ma.getName());
                    MessageBox.Show("The member report was successfully generated and stored in " + ma.getName().Replace("\\s+", "") + ".txt", "Member Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("The member (Number: " + number + ") does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;

        }

        /*
         * generateProviderReport() generate a provider report used by the manager
         */
        public static void generateProviderReport(int number)
        {
            List<ProviderAccounts> providers = DirectoryDB.ReadProviders();

            foreach (ProviderAccounts pa in providers)
            {
                if (pa.getNumber() == number)
                {
                    printProviderReport(pa, pa.getName());
                    MessageBox.Show("The provider report was successfully generated and sorted in " + pa.getName().Replace("\\s+", "") + ".txt", "Provider Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("The provider (Number: " + number + ") does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        /*
         * generateAllMemberReports() will generate a report for all members 
         */
        public static void generateAllMemberReports()
        {
            List<MemberAccounts> members = DirectoryDB.ReadMember();

            foreach (MemberAccounts ma in members)
            {
                printMemberReport(ma, ma.getName());
            }
            // show message: "All member reports successfully generated and stored in writtenFiles/MemberReports"
            MessageBox.Show("All member reports successfully generated and stored in MemberReports", "All Member Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*
         * generateAllProviderReports() will generate a report for all providers
         */
        public static void generateAllProviderReports()
        {
            List<ProviderAccounts> providers = DirectoryDB.ReadProviders();

            foreach (ProviderAccounts pa in providers)
            {
                printProviderReport(pa, pa.getName());
            }

            MessageBox.Show("All provider reports successfully generated and stored in ProviderReports", "All Member Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        /*
         * printMemberReport() prints the member report 
         */
        public static void printMemberReport(MemberAccounts member, String name)
        {
            name = name.Replace("\\s+", "");
            string fileName = name + ".txt";
            string fullPath = Path.Combine(Environment.CurrentDirectory + @"\writtenFiles\MemberReports\", fileName);

            using (StreamWriter input = new StreamWriter(fullPath))
            {
                try
                {
                    input.Write("Member Name: " + member.getName() + "\n" + "Member Number: " + member.getNumber() + "\n" +
                    "Member Address: " + member.getAddress() + "\n" + "Member City: " + member.getCity() +
                    "\n" + "Member State: " + member.getState() + "\n" + "Member Zip Code: " + member.getZipCode() + "\n");

                    List<ServiceRecord> sr = member.getServicesProvided();
                    if (sr != null)
                    {
                        foreach (ServiceRecord service in sr)
                        {
                            input.Write("\n");
                            input.Write("Service Date: " + service.getDateOfService() + "\n" + "Service Provider: " + service.getProviderName(service.getProviderNumber()) +
                                "\n" + "Service Name: " + service.getServiceName(service.getServiceCode()) + "\n");
                        }
                    }
                    input.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Error: File not found", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /*
         * printProviderReport() prints the provider report
         */
        public static void printProviderReport(ProviderAccounts provider, String name)
        {
            name = name.Replace("\\s+", "");
            double totalFee = 0;
            string fileName = name + ".txt";
            string fullPath = Path.Combine(Environment.CurrentDirectory + @"\writtenFiles\ProviderReports\", fileName);

            using (StreamWriter input = new StreamWriter(fullPath))
            {
                try
                {
                    input.Write("Provider Name: " + provider.getName() + "\n" + "Provider Number: " + provider.getNumber() + "\n" + "Provider Address: " + provider.getAddress() +
                    "\n" + "Provider City: " + provider.getCity() + "\n" + "Provider State: " + provider.getState() + "\n" + "Provider Zip Code: " + provider.getZipCode() + "\n");

                    List<ServiceRecord> sr = provider.getServicesProvided();
                    if (sr != null)
                    {
                        foreach (ServiceRecord service in sr)
                        {
                            input.Write("\n");
                            input.Write("Service Date: " + service.getDateOfService() + "\n" + "Date Data Was Received: " + service.getCurrentDateTime() +
                                "\n" + "Member Name: " + service.getMemberName(service.getMemberNumber()) +
                                "\n" + "Member Number: " + service.getMemberNumber() + "\n" + "Service Code: " + service.getServiceCode() +
                                "\n" + "Fee to be paid: " + service.getServiceFee(service.getServiceCode()) + "\n");
                            totalFee = totalFee + service.getServiceFee(service.getServiceCode());
                        }
                        input.Write("Total number of consultations with members: " + sr.Count() + "\n");
                        input.Write("Total fees for the week: $" + totalFee + "\n");
                    }
                    else
                    {
                        input.Write("Total number of consultations with members: 0\n");
                        input.Write("Total fees for the week: $0\n");
                    }
                    input.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Error: File not found", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
