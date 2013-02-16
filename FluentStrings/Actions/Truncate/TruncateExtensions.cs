using dokas.FluentStrings.Actions.Truncate;

namespace dokas.FluentStrings
{
    public static class TruncateExtensions
    {
        public static TruncateString TruncateTo(this string source, int charsCount)
        {
            return new TruncateString(source, charsCount);
        }

        public static TruncateStringFrom From(this TruncateString source, The position)
        {
            return new TruncateStringFrom(source, position);
        }
    }
}
