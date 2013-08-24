using System;
using System.Linq;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings
{
    public static class UtilityExtensions
    {
        /// <summary>
        /// Checks whether string is empty or not.
        /// <para>N.B.: Equivalent of String.IsNullOrEmpty method.</para>
        /// </summary>
        /// <param name="source">Target string for examination</param>
        /// <returns>True if string is null or empty, otherwise false</returns>
        public static IsEmptyString IsEmpty(this string source)
        {
            return new IsEmptyString(source);
        }

        /// <summary>
        /// Adds validation whether string consists only of white-space characters.
        /// <para>N.B.: Equivalent of String.IsNullOrWhiteSpace method.</para>
        /// </summary>
        /// <returns>True if string consists only of white-space characters, otherwise false</returns>
        public static IsEmptyOrWhiteSpaceString OrWhiteSpace(this IsEmptyString source)
        {
            return new IsEmptyOrWhiteSpaceString(source);
        }



        /// <summary>
        /// Replaces the format item in a template with the text equivalent
        /// of the value specified in a values array.
        /// </summary>
        /// <param name="template">Formating template</param>
        /// <param name="values">Values for formating template</param>
        /// <exception cref="System.FormatException">Thrown when formating template is invalid</exception>
        public static string f(this string template, params object[] values)
        {
            if (template == null)
            {
                return null;
            }
            return String.Format(
                template,
                values != null
                    ? values.Select(v => v != null ? v : String.Empty).ToArray()
                    : new[] { String.Empty });
        }



        /// <summary>
        /// Enumerates through indexes of a marker value in a given string.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// <para>N.B.: Default IndexesOf() is equivalent of IndexesOf().From(The.Beginning)</para>
        /// </summary>
        /// <param name="source">Target string for indexing</param>
        /// <param name="value">Marker value</param>
        public static IndexesOfValue IndexesOf(this string source, string value)
        {
            return new IndexesOfValue(source, value);
        }
    }
}
