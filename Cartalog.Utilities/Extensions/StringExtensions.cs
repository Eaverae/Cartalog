namespace Cartalog.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string instance)
        {
            return string.IsNullOrWhiteSpace(instance);
        }

        /// <summary>
        /// Returns a boolean value that indicates whether or not the current instance is null or string.empty
        /// </summary>
        /// <param name="instance">The instance to verify</param>
        /// <returns>A boolean value</returns>
        public static bool IsNullOrEmpty(this string instance)
        {
            return string.IsNullOrEmpty(instance);
        }
    }
}