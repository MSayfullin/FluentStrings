using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingTo
    {
        private readonly RemoveStringStarting _removeStringStarting;
        private readonly int _positionIndex;

        internal RemoveStringStartingTo(RemoveStringStarting removeStringStarting, int positionIndex)
        {
            _removeStringStarting = removeStringStarting;
            _positionIndex = positionIndex;
        }

        internal RemoveStringStarting RemoveStringStarting { get { return _removeStringStarting; } }
        internal int PositionIndex { get { return _positionIndex; } }

        public static implicit operator string(RemoveStringStartingTo removeStringStartingTo)
        {
            return removeStringStartingTo.ToString();
        }

        public override string ToString()
        {
            return _removeStringStarting.RemoveString.Source
                .RemoveStartingTo(_removeStringStarting.PositionIndex, The.Beginning, _positionIndex, The.Beginning);
        }
    }
}
