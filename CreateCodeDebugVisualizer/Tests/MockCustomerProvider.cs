using System.Collections.Generic;
using BusinessObjects;

namespace Tests
{
	public class MockCustomerProvider
	{
		public static Customer GetCustomer()
		{
			var customer = new Customer { Name = "FN LN", Age = 50, IsRegistered = true };
			var addresses = new List<Address>
			                	{
			                		new Address
			                			{AddressLine1 = "UK Address", Country = new Country {Name = "UK"}, PostCode = "UK Post"},
			                		new Address
			                			{AddressLine1 = "US Address", Country = new Country {Name = "US"}, PostCode = "US Post"}
			                	};
			var drivingLicenses = new List<DrivingLicense>
			                      	{
			                      		new DrivingLicense {LicenseNumber = "12345"},
			                      		new DrivingLicense {LicenseNumber = "67890"}
			                      	};
			customer.DrivingLicenses = drivingLicenses.ToArray();
			customer.Addresses = addresses;

			IDictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add(new KeyValuePair<string, string>("Viral", "Shah"));
			customer.UnSupportedType = dictionary;

			return customer;
		}
	}
}