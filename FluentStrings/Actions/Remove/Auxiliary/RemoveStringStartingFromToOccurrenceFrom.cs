using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromToOccurrenceFrom
    {
        private readonly RemoveStringStartingFromToOccurrence _source;
        private readonly The _position;

        internal RemoveStringStartingFromToOccurrenceFrom(RemoveStringStartingFromToOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFromToOccurrenceFrom removeStringStartingFromToOccurrenceFrom)
        {
            return removeStringStartingFromToOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
