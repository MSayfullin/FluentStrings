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
            return _source.Remove(_extraction,
                (s, e) =>
                {
                    var index = s.IndexOf(e);
                    return index >= 0 ? s.Remove(index, e.Length) : s;
                });
        }
    }
}
