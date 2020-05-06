using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace ChocAn
{
    class DirectoryDB
    {
        public class sortList : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }

        /**
         * ReadProviderDirectoryEntry(), reads in the providerDirectory.txt and stores each line as a ProviderDirectoryEntry
         * and returns a list of these providerDirectoryEntries
         */
        public static List<ProviderDirectoryEntry> ReadProviderDirectoryEntry()
        {
            string fileName = "Database/providerDirectory.txt";
            StreamReader input = new StreamReader(fileName);
            string line = input.ReadLine();

            List<ProviderDirectoryEntry> listPde = new List<ProviderDirectoryEntry>();

            if (File.Exists(fileName))
            {
                while (line != null && !line.Equals(""))
                {
                    String[] fields = line.Split(',');
                    ProviderDirectoryEntry entry = new ProviderDirectoryEntry();

                    entry.setServiceName(fields[0]);
                    entry.setServiceCode(int.Parse(fields[1]));
                    entry.setServiceFee(int.Parse(fields[2]));

                    listPde.Add(entry);
                    line = input.ReadLine();
                }
                input.Close();
            }
            return listPde;
        }

        /*
         * ReadMember(), Reads in the member.txt datavase and creats a new memberAccount for member, along with the list of services
         * they have been provided. returns a list of all the members in the database.
         * 
         */
        public static List<MemberAccounts> ReadMember()
        {
            string fileName = "Database/member.txt";
            StreamReader input = new StreamReader(fileName);
            string line = input.ReadLine();

            List<MemberAccounts> listMemA = new List<MemberAccounts>();

            if (File.Exists(fileName))
            {
                while (line != null && !line.Equals(""))
                {
                    String[] fields = line.Split(',');
                    List<ServiceRecord> servicesProvided = new List<ServiceRecord>();

                    MemberAccounts memA = new MemberAccounts();
                    memA.setName(fields[0]);
                    memA.setNumber(int.Parse(fields[1]));
                    memA.setAddress(fields[2]);
                    memA.setCity(fields[3]);
                    memA.setState(fields[4]);
                    memA.setZipCode(int.Parse(fields[5]));
                    memA.setStatus(bool.Parse(fields[6]));

                    line = input.ReadLine();
                    if (line == null)
                    {
                        listMemA.Add(memA);
                        break;
                    }
                    String[] serviceFields = line.Split(',');

                    while (serviceFields[0].Equals('s') == true && serviceFields != null)
                    {
                        ServiceRecord sr = new ServiceRecord();
                        sr.setCurrentDateTime(serviceFields[1]);
                        sr.setDateOfService(serviceFields[2]);
                        sr.setProviderNumber(int.Parse(serviceFields[3]));
                        sr.setMemberNumber(int.Parse(serviceFields[4]));
                        sr.setServiceCode(int.Parse(serviceFields[5]));
                        if (serviceFields.Length == 7) sr.setComments(serviceFields[6]);
                        servicesProvided.Add(sr);
                        line = input.ReadLine();
                        if (line == null) break;
                        serviceFields = line.Split(',');
                    }

                    memA.setServicesProvided(servicesProvided);
                    listMemA.Add(memA);
                }
                input.Close();
            }
            return listMemA;
        }

        /*
         * ReadProviders() reads in the provider.txt database and creats a new ProviderAccount for each provider, along with the list of services
         * they have provided. returns a list of all the providers in the database
         * 
         */
        public static List<ProviderAccounts> ReadProviders()
        {
            string fileName = "Database/provider.txt";
            StreamReader input = new StreamReader(fileName);
            string line = input.ReadLine();
            
            List<ProviderAccounts> listProvA = new List<ProviderAccounts>();

            if (File.Exists(fileName))
            {
                while (line != null && !line.Equals(""))
                {
                    List<ServiceRecord> servicesProvided = new List<ServiceRecord>();
                    String[] fields = line.Split(',');

                    ProviderAccounts provA = new ProviderAccounts();
                    provA.setName(fields[0]);
                    provA.setNumber(int.Parse(fields[1]));
                    provA.setAddress(fields[2]);
                    provA.setCity(fields[3]);
                    provA.setState(fields[4]);
                    provA.setZipCode(int.Parse(fields[5]));

                    line = input.ReadLine();
                    if (line == null)
                    {
                        listProvA.Add(provA);
                        break;
                    }
                    String[] serviceFields = line.Split(',');

                    while (serviceFields[0].Equals('s') == true && serviceFields != null)
                    {
                        ServiceRecord sr = new ServiceRecord();
                        sr.setCurrentDateTime(serviceFields[1]);
                        sr.setDateOfService(serviceFields[2]);
                        sr.setProviderNumber(int.Parse(serviceFields[3]));
                        sr.setMemberNumber(int.Parse(serviceFields[4]));
                        sr.setServiceCode(int.Parse(serviceFields[5]));
                        if (serviceFields.Length == 7) sr.setComments(serviceFields[6]);
                        servicesProvided.Add(sr);
                        line = input.ReadLine();
                        if (line == null) break;
                        serviceFields = line.Split(',');
                    }

                    provA.setServicesProvided(servicesProvided);
                    listProvA.Add(provA);
                }
                input.Close();
            }
            return listProvA;
        }

        /*
         * rewriteDirectory() writes the providerDirectory to ProviderDirectory.txt. This is used for when the provider requests the
         * providerDirectory
         */
         public static void rewriteDirectory()
        {
            List<ProviderDirectoryEntry> pde = ReadProviderDirectoryEntry();

            string fileName = "writtenFiles/ProviderDirectory/ProviderDirectory.txt";
            StreamWriter output = new StreamWriter(fileName);

            foreach (ProviderDirectoryEntry entry in pde)
            {
                output.WriteLine("Service Name: " + entry.getServiceName() + "," + " Service Code: " + entry.getServiceCode() + "," + " Service Fee: $" + entry.getServiceFee() + "\n");
            }

            output.Close();
        }
    }
}
