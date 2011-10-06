using System;
using NUnit.Framework;
using Visualizer.Extensions;

namespace Tests
{
	[TestFixture]
	public class ObjectToCSharpCodeExtensionsTests
	{
		[Test]
		public void CanConvertPropertiesToObjectAssignmentCode()
		{
			Console.WriteLine(MockCustomerProvider.GetCustomer().CreateCode());
		}
	}
}