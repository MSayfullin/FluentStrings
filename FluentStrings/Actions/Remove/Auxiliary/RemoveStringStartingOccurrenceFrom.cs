using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFrom
    {
        private readonly RemoveStringStartingOccurrence _source;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceFrom(RemoveStringStartingOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFrom removeStringStartingOccurrenceFrom)
        {
            return removeStringStartingOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
