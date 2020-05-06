using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAn
{
    class ProviderAccounts
    {
		private string name;
		private int number;
		private string address;
		private string city;
		private string state;
		private int zipCode;
		private List<ServiceRecord> servicesProvided;

		/**
		 * ProviderAccounts(), constructor
		 */
		public ProviderAccounts()
		{

		}

		/**
		 * ProviderAccounts() is a constructor that sets all of the parameters passed in to this entity class
		 */
		public ProviderAccounts(String name, int number, String address, String city, String state, int zipCode)
		{
			this.name = name;
			this.number = number;
			this.address = address;
			this.city = city;
			this.state = state;
			this.zipCode = zipCode;
		}

		/**
		 * setName() sets the name of the provider that is passed in
		 */
		public void setName(String name)
		{
			this.name = name;
		}

		/**
		 * setNumber() sets the number given for that provider
		 */
		public void setNumber(int number)
		{
			this.number = number;
		}

		/**
		 * setAddress() sets the address for that provider
		 */
		public void setAddress(String address)
		{
			this.address = address;
		}

		/**
		 * setCity() sets the city for that provider
		 */
		public void setCity(String city)
		{
			this.city = city;
		}

		/**
		 * setStates() sets the state for that provider
		 */
		public void setState(String state)
		{
			this.state = state;
		}

		/**
		 * setZipCode() sets the zip code for that provider
		 */
		public void setZipCode(int zipCode)
		{
			this.zipCode = zipCode;
		}

		/**
		 * getName() returns the name of the provider
		 */
		public String getName()
		{
			return name;
		}

		/**
		 * getNumber() returns the number of the provider
		 */
		public int getNumber()
		{
			return number;
		}

		/**
		 * getAddress() returns the address of the provider
		 */
		public String getAddress()
		{
			return address;
		}

		/**
		 * getCity() returns the city of the provider
		 */
		public String getCity()
		{
			return city;
		}

		/**
		 * getState() returns the state of the provider
		 */
		public String getState()
		{
			return state;
		}

		/**
		 * getZipCode() returns the zip code of the provider
		 */
		public int getZipCode()
		{
			return zipCode;
		}

		/*
		 * getNumberServices() returns the number of services that the provider has provided
		 */
		 public int getNumberServices()
		{
			if (servicesProvided.Count() == 0) return 0;
			else
			{
				return servicesProvided.Count();
			}
		}

		/*
		 * getTotalFees() returns the total fees
		 * 
		 */
		 public double getTotalFees(List<ServiceRecord> services)
		{
			double fee = 0;
			foreach(ServiceRecord se in services)
			{
				fee = fee + se.getServiceFee(se.getServiceCode());
			}
			return fee;
		}

		/**
		 * getServicesProvided() returns the list of ServiceRecord that the provider has provided
		 * 
		 */
		public List<ServiceRecord> getServicesProvided()
		{
			return servicesProvided;
		}

		/**
		 * addService() takes a ServiceRecord input and adds to the list of ServiceRecord for the provider
		 *
		 */
		public void addService(ServiceRecord service)
		{
			servicesProvided.Add(service);
		}

		/**
		 * setServicesProvided() takes in the list of sericesProvided and stores it in this class
		 * 
		 */
		public void setServicesProvided(List<ServiceRecord> servicesProvided)
		{
			this.servicesProvided = servicesProvided;
		}
	}
}
