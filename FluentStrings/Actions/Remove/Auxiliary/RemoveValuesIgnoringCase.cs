using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValuesIgnoringCase
    {
        private RemoveValues _removeValues;

        internal RemoveValuesIgnoringCase(RemoveValues removeValues)
        {
            _removeValues = removeValues;
        }

        internal RemoveValues RemoveValues { get { return _removeValues; } }

        public static implicit operator string(RemoveValuesIgnoringCase removeValuesIgnoringCase)
        {
            return removeValuesIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeValues.Source.RemoveValues(_removeValues.Quantity, _removeValues.Extraction, ignoreCase: true);
        }
    }
}
