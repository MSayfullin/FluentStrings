using dokas.FluentStrings.Actions.Truncate;

namespace dokas.FluentStrings
{
    public static class TruncateExtensions
    {
        public static TruncateText TruncateTo(this string source, int charsCount)
        {
            return new TruncateText(source, charsCount);
        }

        public static TruncateTextFrom From(this TruncateText source, The position)
        {
            return new TruncateTextFrom(source, position);
        }
    }
}
