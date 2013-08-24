using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Extends any suitable action with the ability to ignore case.
        /// </summary>
        public static T IgnoringCase<T>(this T source) where T : ICaseIgnorable
        {
            source.IgnoreCase();
            return source;
        }

        /// <summary>
        /// Extends any suitable action with the ability to change starting point.
        /// <para>N.B.: From(The.Beginning) is the default behavior of all actions.</para>
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static T From<T>(this T source, The position) where T : IPositional
        {
            if (position == The.StartOf || position == The.EndOf)
            {
                throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by From() method");
            }

            source.Set(position);
            return source;
        }
    }
}
