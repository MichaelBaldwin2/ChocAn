using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
    class MemberAccounts
    {
        private string name;
        private int number;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private bool status;
        private List<ServiceRecord> servicesProvided;

        public MemberAccounts() // constructor
        {

        }

        /*
         * MemberAccounts() constructor with all of the parameters needed to create a new member
         */
        public MemberAccounts (string name, int number, string address, string city, string state, int zipCode, bool status, List<ServiceRecord> servicesProvided) 
        {
            this.name       = name;     // name of new member
            this.number     = number;   // a unique 9 digit number assigned for the member
            this.address    = address;  // address of the member
            this.city       = city;     
            this.state      = state;
            this.zipCode    = zipCode;
            this.status     = status;   // status of the member (true= not suspended, false=suspended)
            this.servicesProvided = servicesProvided; // list of services received
        }

		// MemberAccounts another constructor for members without any services received
        public MemberAccounts(string name, int number, string address, string city, string state, int zipCode, bool status) 
        {
            this.name		= name;     // name of new member
            this.number		= number;   // a unique 9 digit number assigned for the member
            this.address	= address;  // address of the member
            this.city		= city;
            this.state		= state;
            this.zipCode	= zipCode;
            this.status		= status;   // status of the member (true= not suspended, false=suspended)
        }

		/**
		 * setServicesProvided() takes in the list of services provided for the member and stores it
		 */
		public void setServicesProvided(List<ServiceRecord> servicesProvided)
		{
			this.servicesProvided = servicesProvided;
		}

		/**
		 * setName() sets the name of the member
		 */
		public void setName(String name)
		{
			this.name = name;
		}

		/**
		 * setNumber() sets the unique member number that is passed in
		 */
		public void setNumber(int number)
		{
			this.number = number;
		}

		/**
		 * setAddress() sets the address of the member
		 */
		public void setAddress(String address)
		{
			this.address = address;
		}

		/**
		 * setCity() sets the city of the member
		 */
		public void setCity(String city)
		{
			this.city = city;
		}

		/**
		 * setState() sets the state of the member
		 */
		public void setState(String state)
		{
			this.state = state;
		}

		/**
		 * setZipCode() sets the zip code for that member
		 */
		public void setZipCode(int zipCode)
		{
			this.zipCode = zipCode;
		}

		/**
		 * setStatus() sets the status of the member (true = not suspended, false = suspended)
		 */
		public void setStatus(bool status)
		{
			this.status = status;
		}

		/**
		 * getName() returns the name of the member
		 */
		public String getName()
		{
			return name;
		}

		/**
		 * getNumber() returns the unique number for the member
		 */
		public int getNumber()
		{
			return number;
		}

		/**
		 * getAddress() returns the address of the member
		 */
		public String getAddress()
		{
			return address;
		}

		/**
		 * getCity() returns the city of the member
		 */
		public String getCity()
		{
			return city;
		}

		/**
		 * getState() returns the state of the member
		 */
		public String getState()
		{
			return state;
		}

		/**
		 * getZipCode() returns the zip code of the member
		 */
		public int getZipCode()
		{
			return zipCode;
		}

		/**
		 * getStatus() returns the status of the member (true = not suspended, false = suspended)
		 */
		public bool getStatus()
		{
			return status;
		}

		/**
		 * getServicesProvided() returns the list of ServiceRecord that the member has received
		 */
		public List<ServiceRecord> getServicesProvided()
		{
			return servicesProvided;
		}

		/**
		 * addService() takes a ServiceRecord and adds to the list of ServiceRecord for the member
		 */
		public void addService(ServiceRecord service)
		{
			servicesProvided.Add(service);
		}
	}
}
