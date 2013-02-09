using System;

namespace dokas.FluentStrings.Actions.Remove.Resources
{
    internal static class VowelsMap
    {
        public static char[] GetFor(string cultureName)
        {
            switch (cultureName)
            {
                case "en":
                case "en-US":
                case "en-CA":
                case "en-GB":
                case "en-NZ":
                case "en-IE":
                case "en-AU":
                    return new char[] { 'a', 'e', 'i', 'o', 'u' };
                case "ru":
                case "ru-RU":
                    return new char[] { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е' };
                default:
                    return new char[] { };
            }
        }
    }
}
