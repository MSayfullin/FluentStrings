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
    }
}
