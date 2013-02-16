using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFromToOccurrencePositionFrom
    {
        private readonly RemoveStringStartingOccurrenceFromToOccurrencePosition _source;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceFromToOccurrencePositionFrom(RemoveStringStartingOccurrenceFromToOccurrencePosition source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFromToOccurrencePositionFrom removeStringStartingOccurrenceFromToOccurrencePositionFrom)
        {
            return removeStringStartingOccurrenceFromToOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
