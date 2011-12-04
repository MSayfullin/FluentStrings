using System;
using dokas.FluentStrings.Actions.Replace;

namespace dokas.FluentStrings
{
    public static class ReplaceExtensions
    {
        public static ReplaceText Replace(this string source, string value)
        {
            return new ReplaceText(source, value);
        }

        public static ReplaceTextWith With(this ReplaceText source, string replacement)
        {
            return new ReplaceTextWith(source, replacement);
        }

        public static ReplaceTextWithIgnoringCase IgnoringCase(this ReplaceTextWith source)
        {
            return new ReplaceTextWithIgnoringCase(source);
        }
    }
}

