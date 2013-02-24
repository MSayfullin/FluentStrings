using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValuesIgnoringCase
    {
        private RemoveValues _removeValues;

        public RemoveValuesIgnoringCase(RemoveValues removeValues)
        {
            _removeValues = removeValues;
        }

        public static implicit operator string(RemoveValuesIgnoringCase removeValuesIgnoringCase)
        {
            return removeValuesIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return CommonLogic.RemoveValues(_removeValues.Source, _removeValues.Quantity, _removeValues.Extraction, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
