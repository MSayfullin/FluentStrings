using System;

namespace dokas.FluentStrings
{
    public static class Utilities
    {
        /// <summary>
        /// Checks whether string is empty or not
        /// N.B.: Equivalent of String.IsNullOrEmpty method
        /// </summary>
        /// <param name="source">Target string for examination</param>
        /// <returns>True if string is null or empty, otherwise false</returns>
        public static bool IsEmpty(this string source)
        {
            // TODO: Use String.IsNullOrWhiteSpace() when switched to .NET 4.0
            return String.IsNullOrEmpty(source);
        }

        /// <summary>
        /// Replaces the format item in a template with the text equivalent
        /// of the value specified in a values array.
        /// </summary>
        /// <param name="template">Formating template</param>
        /// <param name="values">Values for fomating template</param>
        public static string Format(this string template, params object[] values)
        {
            return String.Format(template, values);
        }
    }
}
