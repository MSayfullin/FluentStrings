using System;

namespace dokas.FluentStrings
{
    public static class ReplaceExtensions
    {
        public static ReplacePattern Replace(this string source, string pattern)
        {
            return new ReplacePattern(source, pattern);
        }

        public static ReplacePattern FirstOccurrence(this ReplacePattern source)
        {
            return new ReplacePattern(source, true, false, false);
        }

        public static ReplacePattern LastOccurrence(this ReplacePattern source)
        {
            return new ReplacePattern(source, false, true, false);
        }

        public static ReplacePattern All(this ReplacePattern source)
        {
            return new ReplacePattern(source, false, false, true);
        }

        public static ReplaceWith With(this ReplacePattern source, string text)
        {
            return new ReplaceWith(source, text);
        }

        public static ReplaceWith SeparatedBy(this ReplaceWith source, char symbol)
        {
            return new ReplaceWith(source, symbol);
        }

        public static ReplaceWith SeparatedBy(this ReplaceWith source, string symbol)
        {
            return new ReplaceWith(source, symbol);
        }

        public static ReplaceWithSeparatedByIgnoringCase IgnoringCase(this ReplaceWith source)
        {
            return new ReplaceWithSeparatedByIgnoringCase(source);
        }
    }
}

