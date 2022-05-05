namespace Cartalog.Utilities.Extensions
{
    /// <summary>
    /// Class StringExtensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether [is null or white space] [the specified instance].
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns><c>true</c> if [is null or white space] [the specified instance]; otherwise, <c>false</c>.</returns>
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