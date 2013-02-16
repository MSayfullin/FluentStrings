using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrenceFrom
    {
        private readonly RemoveStringStartingToOccurrence _source;
        private readonly The _position;

        internal RemoveStringStartingToOccurrenceFrom(RemoveStringStartingToOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingToOccurrenceFrom removeStringStartingToOccurrenceFrom)
        {
            return removeStringStartingToOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
