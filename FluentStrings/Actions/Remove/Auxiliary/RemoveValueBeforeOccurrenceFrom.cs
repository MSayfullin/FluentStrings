using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueBeforeOccurrenceFrom
    {
        private readonly RemoveValueBeforeOccurrence _removeValueBeforeOccurrence;
        private readonly The _position;

        internal RemoveValueBeforeOccurrenceFrom(RemoveValueBeforeOccurrence removeValueBeforeOccurrence, The position)
        {
            _removeValueBeforeOccurrence = removeValueBeforeOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveValueBeforeOccurrenceFrom removeValueBeforeOccurrenceFrom)
        {
            return removeValueBeforeOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
