using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
    class ServiceRecord
    {
        private string currentDateTime;
        private string dateOfService;
        private int providerNumber;
        private int memberNumber;
        private int serviceCode;
        private string comments;

        /**
         * serviceRecord(), a constructor
         */
        public ServiceRecord()
        {

        }

        /**
         * serviceRecord(), is a constructor that stores all of the variables passed in
         */

        public ServiceRecord(string currentDateTime, string dateOfService, int providerNumber, int memberNumber,
          int serviceCode, string comments)
        {
            this.currentDateTime = currentDateTime;
            this.dateOfService = dateOfService;
            this.providerNumber = providerNumber;
            this.memberNumber = memberNumber;
            this.serviceCode = serviceCode;
            this.comments = comments;
        }

        /**
         * getCurrentDateTime() returns currentDateTime for the service
         */
        public string getCurrentDateTime()
        {
            return currentDateTime;
        }

        /*
         * setCurrentDateTime() sets currentDateTime for the service
         */
        public void setCurrentDateTime(string currentDateTime)
        {
            this.currentDateTime = currentDateTime;
        }

        /**
         * getDateOfService() returns the date of service
         */
        public string getDateOfService()
        {
            return dateOfService;
        }

        /**
         * setDateOfService() sets date that the service was provided
         */
        public void setDateOfService(string dateOfService)
        {
            this.dateOfService = dateOfService;
        }

        /**
         * getProviderName() takes the provider number and searches for the provider to return the their name
         */
        public string getProviderName(int providerNumber)
        {
            List<ProviderAccounts> pa = DirectoryDB.ReadProviders();
            String name = null;
            
            foreach (ProviderAccounts provide in pa) 
            {
                if (provide.getNumber() == providerNumber) {
                name = provide.getName();
                }
            }
        return name;
        }

        public String getMemberName(int memberNumber)
        {
            List<MemberAccounts> ma = DirectoryDB.ReadMember();
            String name = null; 
      
            foreach (MemberAccounts member in ma) 
            {
                if (member.getNumber() == memberNumber) 
                {
                name = member.getName();
                }
            }
            return name;  
        }

        /**
         * getProviderNumber() returns the provider number
         */
        public int getProviderNumber()
        {
            return providerNumber;
        }

        /**
         * setProviderNumber() sets the provider number
         *
         */
        public void setProviderNumber(int providerNumber)
        {
            this.providerNumber = providerNumber;
        }

        /**
         * getMemberNumber() returns the member number
         *
         */
        public int getMemberNumber()
        {
            return memberNumber;
        }

        /**
         * setMemberNumber() sets the member number
         * 
         */
        public void setMemberNumber(int memberNumber)
        {
            this.memberNumber = memberNumber;
        }

        /**
         * getServiceCode() returns the service code
         * 
         */
        public int getServiceCode()
        {
            return serviceCode;
        }

        /**
         * setServiceCode() sets the service code
         * 
         */
        public void setServiceCode(int serviceCode)
        {
            this.serviceCode = serviceCode;
        }

        /**
         * getComments() returns the comments
         * 
         */
        public String getComments()
        {
            return comments;
        }

        /**
         * setComments() sets the comments
         * 
         */
        public void setComments(String comments)
        {
            this.comments = comments;
        }

        /**
         * getServiceName() takes in a service code and looks up the service to return its name
         */
        public String getServiceName(int serviceCode)
        {
            List<ProviderDirectoryEntry> pde = DirectoryDB.ReadProviderDirectoryEntry();
            String name = null;
            foreach (ProviderDirectoryEntry provide in pde) 
            {
                if (provide.getServiceCode() == serviceCode) 
                {
                name = provide.getServiceName();
                }
            }
            return name;
         }

  /**
   * getServiceFee() takes in a service code and searches the service to return its fee
   */
  public double getServiceFee(int serviceCode) 
        {
            List<ProviderDirectoryEntry> pde = DirectoryDB.ReadProviderDirectoryEntry();
            double fee = 0;
            foreach (ProviderDirectoryEntry provide in pde) 
            {
                if (provide.getServiceCode() == serviceCode) 
                { 
                
                    fee = provide.getServiceFee();
                }
            }
            return fee;
	    }
    }
}
