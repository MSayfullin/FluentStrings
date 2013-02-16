using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFromToOccurrenceFrom
    {
        private readonly RemoveStringStartingOccurrenceFromToOccurrence _source;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceFromToOccurrenceFrom(RemoveStringStartingOccurrenceFromToOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFromToOccurrenceFrom removeStringStartingOccurrenceFromToOccurrenceFrom)
        {
            return removeStringStartingOccurrenceFromToOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
