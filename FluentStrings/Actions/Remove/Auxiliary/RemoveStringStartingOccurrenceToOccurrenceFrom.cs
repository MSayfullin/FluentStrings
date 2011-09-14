using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceToOccurrenceFrom
    {
        private readonly RemoveStringStartingOccurrenceToOccurrence _source;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceToOccurrenceFrom(RemoveStringStartingOccurrenceToOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceToOccurrenceFrom removeStringStartingOccurrenceToOccurrenceFrom)
        {
            return removeStringStartingOccurrenceToOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
