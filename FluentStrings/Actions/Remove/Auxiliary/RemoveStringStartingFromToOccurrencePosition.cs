using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromToOccurrencePosition
    {
        private readonly RemoveStringStartingFrom _source;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingFromToOccurrencePosition(RemoveStringStartingFrom source,  The position, int occurrenceCount, string marker)
        {
            _source = source;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingFromToOccurrencePosition removeStringStartingFromToOccurrencePosition)
        {
            return removeStringStartingFromToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
