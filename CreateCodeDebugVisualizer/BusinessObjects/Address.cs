using System;

namespace BusinessObjects
{
	[Serializable]
	public class Address
	{
		public string AddressLine1 { get; set; }
		public string PostCode { get; set; }
		public Country Country { get; set; }
	}
}