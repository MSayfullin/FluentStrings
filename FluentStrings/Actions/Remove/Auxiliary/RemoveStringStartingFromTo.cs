using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromTo
    {
        private readonly RemoveStringStartingFrom _source;
        private readonly int _positionIndex;

        internal RemoveStringStartingFromTo(RemoveStringStartingFrom source, int positionIndex)
        {
            _source = source;
            _positionIndex = positionIndex;
        }

        public static implicit operator string(RemoveStringStartingFromTo removeStringStartingFromTo)
        {
            return removeStringStartingFromTo.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
