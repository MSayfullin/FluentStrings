using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrencePositionFrom
    {
        private readonly RemoveStringStartingToOccurrencePosition _source;
        private readonly The _position;

        internal RemoveStringStartingToOccurrencePositionFrom(RemoveStringStartingToOccurrencePosition source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingToOccurrencePositionFrom removeStringStartingToOccurrencePositionFrom)
        {
            return removeStringStartingToOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
