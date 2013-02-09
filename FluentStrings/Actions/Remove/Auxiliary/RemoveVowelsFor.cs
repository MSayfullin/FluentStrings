using dokas.FluentStrings.Actions.Remove.Resources;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveVowelsFor
    {
        private readonly RemoveVowels _removeVowels;
        private readonly string _cultureName;

        internal RemoveVowelsFor(RemoveVowels removeVowels, string cultureName)
        {
            _removeVowels = removeVowels;
            _cultureName = cultureName;
        }

        public static implicit operator string(RemoveVowelsFor removeVowelsFor)
        {
            return removeVowelsFor.ToString();
        }

        public override string ToString()
        {
            var vowels = VowelsMap.GetFor(_cultureName);
            return _removeVowels.Source.RemoveChars(vowels).IgnoringCase();
        }
    }
}
