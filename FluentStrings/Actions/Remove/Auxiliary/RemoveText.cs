using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveText
    {
        private readonly string _source;
        private readonly string _extraction;

        internal RemoveText(string source, string extraction)
        {
            _source = source;
            _extraction = extraction;
        }

        public static implicit operator string(RemoveText removeText)
        {
            return removeText.ToString();
        }

        public override string ToString()
        {
            return (_source == null)
                ? null
                : (String.IsNullOrEmpty(_extraction))
                    ? _source
                    : _source.Replace(_extraction, String.Empty);
        }
    }
}
