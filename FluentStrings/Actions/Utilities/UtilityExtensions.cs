using System;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings
{
    public static class UtilityExtensions
    {
        /// <summary>
        /// Checks whether string is empty or not.
        /// N.B.: Equivalent of String.IsNullOrEmpty method.
        /// </summary>
        /// <param name="source">Target string for examination</param>
        /// <returns>True if string is null or empty, otherwise false</returns>
        public static IsEmptyString IsEmpty(this string source)
        {
            return new IsEmptyString(source);
        }

        /// <summary>
        /// Adds validation whether string consists only of white-space characters.
        /// N.B.: Equivalent of String.IsNullOrWhiteSpace method.
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
        /// <param name="values">Values for fomating template</param>
        public static string Format(this string template, params object[] values)
        {
            return String.Format(template, values);
        }



        /// <summary>
        /// Enumerates through indexes of a marker value in a given string.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// N.B.: Default IndexesOf() is equivalent of IndexesOf().From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for indexing</param>
        /// <param name="value">Marker value</param>
        public static IndexesOfValue IndexesOf(this string source, string value)
        {
            return new IndexesOfValue(source, value);
        }

        /// <summary>
        /// Extends IndexesOf action with the ability to ignore case.
        /// </summary>
        public static IndexesOfValueIgnoringCase IgnoringCase(this IndexesOfValue source)
        {
            return new IndexesOfValueIgnoringCase(source);
        }

        /// <summary>
        /// Extends IndexesOf action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static IndexesOfValueFrom From(this IndexesOfValue source, The position)
        {
            return new IndexesOfValueFrom(source, position);
        }

        /// <summary>
        /// Extends IndexesOf.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static IndexesOfValueIgnoringCaseFrom From(this IndexesOfValueIgnoringCase source, The position)
        {
            return new IndexesOfValueIgnoringCaseFrom(source, position);
        }
    }
}
