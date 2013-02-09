using System;
using System.Threading;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveVowels
    {
        private readonly string _source;

        internal RemoveVowels(string source)
        {
            _source = source;
        }

        public static implicit operator string(RemoveVowels removeVowels)
        {
            return removeVowels.ToString();
        }

        public override string ToString()
        {
            char[] vowels;
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en":
                case "en-US":
                case "en-CA":
                case "en-GB":
                case "en-NZ":
                case "en-IE":
                case "en-AU":
                    vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
                    break;
                case "ru":
                case "ru-RU":
                    vowels = new char[] { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е' };
                    break;
                default:
                    vowels = new char[0];
                    break;
            }
            return _source.RemoveChars(vowels).IgnoringCase();
        }
    }
}
