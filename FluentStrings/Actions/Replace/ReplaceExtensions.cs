using System;
using dokas.FluentStrings.Actions.Replace;

namespace dokas.FluentStrings
{
    public static class ReplaceExtensions
    {
        public static ReplaceString Replace(this string source, string value)
        {
            return new ReplaceString(source, value);
        }

        public static ReplaceStringWith With(this ReplaceString source, string replacement)
        {
            return new ReplaceStringWith(source, replacement);
        }

        public static ReplaceStringWithIgnoringCase IgnoringCase(this ReplaceStringWith source)
        {
            return new ReplaceStringWithIgnoringCase(source);
        }
    }
}
