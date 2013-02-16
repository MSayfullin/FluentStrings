using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFromToOccurrencePosition
    {
        private readonly RemoveStringStartingOccurrenceFrom _source;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingOccurrenceFromToOccurrencePosition(RemoveStringStartingOccurrenceFrom source, The position, int occurrenceCount, string marker)
        {
            _source = source;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFromToOccurrencePosition removeStringStartingOccurrenceFromToOccurrencePosition)
        {
            return removeStringStartingOccurrenceFromToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
