using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValuesIgnoringCaseFrom
    {
        private readonly RemoveValuesIgnoringCase _removeValuesIgnoringCase;
        private readonly The _position;

        public RemoveValuesIgnoringCaseFrom(RemoveValuesIgnoringCase removeValuesIgnoringCase, The position)
        {
            _removeValuesIgnoringCase = removeValuesIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveValuesIgnoringCaseFrom removeValuesIgnoringCaseFrom)
        {
            return removeValuesIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return CommonLogic.RemoveValues(
                _removeValuesIgnoringCase.RemoveValues.Source,
                _removeValuesIgnoringCase.RemoveValues.Quantity,
                _removeValuesIgnoringCase.RemoveValues.Extraction,
                StringComparison.CurrentCultureIgnoreCase,
                _position);
        }
    }
}
