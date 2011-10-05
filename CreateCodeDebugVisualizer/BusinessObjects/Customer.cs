using System;
using System.Collections.Generic;

namespace BusinessObjects
{
	[Serializable]
	public class Customer
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public bool IsRegistered { get; set; }
		public IEnumerable<Address> Addresses { get; set; }
		public DrivingLicense[] DrivingLicenses { get; set; }
		public IDictionary<string, string> UnSupportedType { get; set; }
		public CreditCard CreditCard { get; set; }
	}
}