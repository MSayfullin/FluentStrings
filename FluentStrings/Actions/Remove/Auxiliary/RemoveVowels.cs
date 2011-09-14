using System;

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
            throw new NotImplementedException();
        }
    }
}
