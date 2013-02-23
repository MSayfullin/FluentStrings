using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveAll
    {
        private readonly string _source;
        private readonly string _extraction;

        internal RemoveAll(string source, string extraction)
        {
            _source = source;
            _extraction = extraction;
        }

        internal string Source { get { return _source; } }
        internal string Extraction { get { return _extraction; } }

        public static implicit operator string(RemoveAll removeAll)
        {
            return removeAll.ToString();
        }

        public override string ToString()
        {
            return (_source.IsEmpty() || _extraction.IsEmpty())
                ? _source
                : _source.Replace(_extraction, String.Empty);
        }
    }
}
