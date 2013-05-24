using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromTo
    {
        private readonly RemoveStringStartingFrom _removeStringStartingFrom;
        private readonly int _positionIndex;

        internal RemoveStringStartingFromTo(RemoveStringStartingFrom removeStringStartingFrom, int positionIndex)
        {
            _removeStringStartingFrom = removeStringStartingFrom;
            _positionIndex = positionIndex;
        }

        internal RemoveStringStartingFrom RemoveStringStartingFrom { get { return _removeStringStartingFrom; } }
        internal int PositionIndex { get { return _positionIndex; } }

        public static implicit operator string(RemoveStringStartingFromTo removeStringStartingFromTo)
        {
            return removeStringStartingFromTo.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFrom.RemoveStringStarting.RemoveString.Source
                .RemoveStartingTo(_removeStringStartingFrom.RemoveStringStarting.PositionIndex, _removeStringStartingFrom.Position, _positionIndex, The.Beginning);
        }
    }
}
