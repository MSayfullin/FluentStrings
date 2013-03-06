using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValues
    {
        private readonly string _source;
        private readonly int _quantity;
        private readonly string _extraction;

        internal RemoveValues(string source, int quantity, string extraction)
        {
            _source = source;
            _quantity = quantity;
            _extraction = extraction;
        }

        internal string Source { get { return _source; } }
        internal int Quantity { get { return _quantity; } }
        internal string Extraction { get { return _extraction; } }

        public static implicit operator string(RemoveValues removeValues)
        {
            return removeValues.ToString();
        }

        public override string ToString()
        {
            return _source.RemoveValues(_quantity, _extraction, StringComparison.CurrentCulture);
        }
    }
}
