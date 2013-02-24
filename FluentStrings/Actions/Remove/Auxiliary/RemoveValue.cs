using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValue
    {
        private readonly string _source;
        private readonly string _extraction;

        internal RemoveValue(string source, string extraction)
        {
            _source = source;
            _extraction = extraction;
        }

        internal string Source { get { return _source; } }
        internal string Extraction { get { return _extraction; } }

        public static implicit operator string(RemoveValue removeValue)
        {
            return removeValue.ToString();
        }

        public override string ToString()
        {
            if (_source.IsEmpty() || _extraction.IsEmpty())
                return _source;

            var index = _source.IndexOf(_extraction);
            return index >= 0 ? _source.Remove(index, _extraction.Length) : _source;
        }
    }
}
