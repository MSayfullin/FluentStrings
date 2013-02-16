using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceToOccurrencePosition
    {
        private readonly RemoveStringStartingOccurrence _source;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingOccurrenceToOccurrencePosition(RemoveStringStartingOccurrence source, The position, int occurrenceCount, string marker)
        {
            _source = source;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceToOccurrencePosition removeStringStartingOccurrenceToOccurrencePosition)
        {
            return removeStringStartingOccurrenceToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
