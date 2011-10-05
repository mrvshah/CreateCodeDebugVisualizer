using System.Reflection;

namespace Visualizer.Extensions
{
	public static class PropertyInfoExtensions
	{
		public static bool IsOfType<T>(this PropertyInfo propertyInfo)
		{
			return typeof(T).IsAssignableFrom(propertyInfo.PropertyType);
		}

		public static object GetValue(this PropertyInfo propertyInfo, object obj, object[] index = null)
		{
			return propertyInfo.GetValue(obj, index);
		}
	}
}