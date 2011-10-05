namespace Visualizer.Extensions
{
	public static class ObjectExtensions
	{
		public static bool IsOfType<T>(this object obj)
		{
			return typeof(T).IsAssignableFrom(obj.GetType());
		}
	}
}