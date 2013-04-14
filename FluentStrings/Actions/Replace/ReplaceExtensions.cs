using System;
using dokas.FluentStrings.Actions.Replace;

namespace dokas.FluentStrings
{
    public static class ReplaceExtensions
    {
        /// <summary>
        /// Replaces all occurences of given value in the source string.
        /// Empty string is used for replacement, use With extension to change this value.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// </summary>
        /// <param name="source">Target string for replacement</param>
        /// <param name="value">String to be replaced</param>
        public static ReplaceString ReplaceAll(this string source, string value)
        {
            return new ReplaceString(source, value);
        }

        /// <summary>
        /// Extends ReplaceAll action with the replacement value.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// </summary>
        /// <param name="replacement">Value for replacement</param>
        public static ReplaceStringWith With(this ReplaceString source, string replacement)
        {
            return new ReplaceStringWith(source, replacement);
        }

        /// <summary>
        /// Extends ReplaceAll.With action with the ability to ignore case.
        /// </summary>
        public static ReplaceStringWithIgnoringCase IgnoringCase(this ReplaceStringWith source)
        {
            return new ReplaceStringWithIgnoringCase(source);
        }
    }
}
