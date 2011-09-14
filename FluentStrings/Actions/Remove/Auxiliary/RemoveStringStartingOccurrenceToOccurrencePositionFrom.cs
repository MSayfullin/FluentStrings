using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceToOccurrencePositionFrom
    {
        private readonly RemoveStringStartingOccurrenceToOccurrencePosition _source;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceToOccurrencePositionFrom(RemoveStringStartingOccurrenceToOccurrencePosition source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceToOccurrencePositionFrom removeStringStartingOccurrenceToOccurrencePositionFrom)
        {
            return removeStringStartingOccurrenceToOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
