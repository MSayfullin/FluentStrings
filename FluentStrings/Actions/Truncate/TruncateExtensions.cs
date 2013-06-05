using dokas.FluentStrings.Actions.Truncate;

namespace dokas.FluentStrings
{
    public static class TruncateExtensions
    {
        /// <summary>
        /// Truncates source string to a specified length.
        /// <para>N.B.: Default TruncateTo() is equivalent of TruncateTo().From(The.Beginning)</para>
        /// </summary>
        /// <param name="source">Target string for truncating</param>
        /// <param name="length">Length of a resulting string</param>
        public static TruncateString TruncateTo(this string source, int length)
        {
            return new TruncateString(source, length);
        }

        /// <summary>
        /// Extends Truncate action with the ability to append custom text at the end.
        /// <para>N.B.: Pay attention that length specified for truncate includes appended value.</para>
        /// <param name="value">String to be appended at the end</param>
        /// </summary>
        public static TruncateStringWith With(this TruncateString source, string value)
        {
            return new TruncateStringWith(source, value);
        }

        /// <summary>
        /// Extends Truncate action with the ability to append ellipsis at the end.
        /// <para>N.B.: Pay attention that length specified for truncate includes ellipsis.</para>
        /// </summary>
        public static TruncateStringWith WithEllipsis(this TruncateString source)
        {
            return new TruncateStringWith(source, "...");
        }

        /// <summary>
        /// Extends Truncate action with the ability to change starting point.
        /// <para>N.B.: TruncateTo().From(The.Beginning) is equivalent of the default TruncateTo()</para>
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static TruncateStringFrom From(this TruncateString source, The position)
        {
            return new TruncateStringFrom(source, position);
        }
    }
}
