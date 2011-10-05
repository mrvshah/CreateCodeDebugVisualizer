namespace Visualizer.Extensions
{
	public static class StringExtensions
	{
		public static string ToCamelCase(this string str)
		{
			return string.Format("{0}{1}", str[0].ToString().ToLower(), str.Substring(1));
		}
	}
}