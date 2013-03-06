using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValuesFrom
    {
        private readonly RemoveValues _removeValues;
        private readonly The _position;

        internal RemoveValuesFrom(RemoveValues source, The position)
        {
            _removeValues = source;
            _position = position;
        }

        public static implicit operator string(RemoveValuesFrom removeValuesFrom)
        {
            return removeValuesFrom.ToString();
        }

        public override string ToString()
        {
            return _removeValues.Source.RemoveValues(_removeValues.Quantity, _removeValues.Extraction, StringComparison.CurrentCulture, _position);
        }
    }
}
