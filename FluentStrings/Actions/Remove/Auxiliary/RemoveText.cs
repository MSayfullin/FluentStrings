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

        internal String Source { get { return _source; } }
        internal String Extraction { get { return _extraction; } }

        public static implicit operator string(RemoveText removeText)
        {
            return removeText.ToString();
        }

        public override string ToString()
        {
            return (_source == null || _extraction.IsEmpty())
                ? _source
                : _source.Remove(_source.IndexOf(_extraction), _extraction.Length);
        }
    }
}
