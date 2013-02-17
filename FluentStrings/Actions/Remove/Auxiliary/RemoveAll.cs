using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveAllText
    {
        private readonly string _source;
        private readonly string _extraction;

        internal RemoveAllText(string source, string extraction)
        {
            _source = source;
            _extraction = extraction;
        }

        public static implicit operator string(RemoveAllText removeAllText)
        {
            return removeAllText.ToString();
        }

        public override string ToString()
        {
            return (_source == null || _extraction.IsEmpty())
                ? _source
                : _source.Replace(_extraction, String.Empty);
        }
    }
}
