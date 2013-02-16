using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceTo
    {
        private readonly RemoveStringStartingOccurrence _source;
        private readonly int _positionIndex;

        internal RemoveStringStartingOccurrenceTo(RemoveStringStartingOccurrence source, int positionIndex)
        {
            _source = source;
            _positionIndex = positionIndex;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceTo removeStringStartingOccurrenceTo)
        {
            return removeStringStartingOccurrenceTo.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
