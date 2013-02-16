using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFromTo
    {
        private readonly RemoveStringStartingOccurrenceFrom _source;
        private readonly int _positionIndex;

        internal RemoveStringStartingOccurrenceFromTo(RemoveStringStartingOccurrenceFrom source, int positionIndex)
        {
            _source = source;
            _positionIndex = positionIndex;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFromTo removeStringStartingOccurrenceFromTo)
        {
            return removeStringStartingOccurrenceFromTo.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
