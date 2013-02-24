using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValues
    {
        private readonly string _source;
        private readonly int _quantity;
        private readonly string _extraction;

        public RemoveValues(string source, int quantity, string extraction)
        {
            _source = source;
            _quantity = quantity;
            _extraction = extraction;
        }

        public static implicit operator string(RemoveValues removeValues)
        {
            return removeValues.ToString();
        }

        public override string ToString()
        {
            return CommonLogic.RemoveValues(_source, _quantity, _extraction, StringComparison.CurrentCulture);
        }
    }
}
