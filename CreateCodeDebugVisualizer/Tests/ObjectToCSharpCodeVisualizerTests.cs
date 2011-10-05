using System;
using NUnit.Framework;
using Visualizer;

namespace Tests
{
	[TestFixture]
	public class ObjectToCSharpCodeVisualizerTests
	{
		[Test, Ignore]
		public void Test()
		{
			ObjectToCSharpCodeVisualizer.TestShowVisualizer(new WeakReference(MockCustomerProvider.GetCustomer()));
		}
	}
}
