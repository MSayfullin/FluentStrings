using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromToOccurrencePositionFrom
    {
        private readonly RemoveStringStartingFromToOccurrencePosition _source;
        private readonly The _position;

        internal RemoveStringStartingFromToOccurrencePositionFrom(RemoveStringStartingFromToOccurrencePosition source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFromToOccurrencePositionFrom removeStringStartingFromToOccurrencePositionFrom)
        {
            return removeStringStartingFromToOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
