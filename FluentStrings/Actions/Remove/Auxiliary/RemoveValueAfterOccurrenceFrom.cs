using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueAfterOccurrenceFrom
    {
        private readonly RemoveValueAfterOccurrence _removeValueAfterOccurrence;
        private readonly The _position;

        internal RemoveValueAfterOccurrenceFrom(RemoveValueAfterOccurrence removeValueAfterOccurrence, The position)
        {
            _removeValueAfterOccurrence = removeValueAfterOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveValueAfterOccurrenceFrom removeValueAfterOccurrenceFrom)
        {
            return removeValueAfterOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
