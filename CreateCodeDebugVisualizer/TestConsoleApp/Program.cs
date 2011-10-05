using System.Collections.Generic;
using BusinessObjects;

namespace TestConsoleApp
{
	class Program
	{
		static void Main()
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
		}
	}
}
