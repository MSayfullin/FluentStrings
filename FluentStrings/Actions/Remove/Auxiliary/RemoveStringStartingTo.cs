using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingTo
    {
        private readonly RemoveStringStarting _source;
        private readonly int _positionIndex;

        internal RemoveStringStartingTo(RemoveStringStarting source, int positionIndex)
        {
            _source = source;
            _positionIndex = positionIndex;
        }

        public static implicit operator string(RemoveStringStartingTo removeStringStartingTo)
        {
            return removeStringStartingTo.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
