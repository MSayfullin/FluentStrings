using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrencePosition
    {
        private readonly RemoveStringStarting _source;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingToOccurrencePosition(RemoveStringStarting source, The position, int occurrenceCount, string marker)
        {
            _source = source;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingToOccurrencePosition removeStringStartingToOccurrencePosition)
        {
            return removeStringStartingToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
