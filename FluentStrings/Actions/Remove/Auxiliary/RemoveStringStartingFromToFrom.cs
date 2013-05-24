using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromToFrom
    {
        private readonly RemoveStringStartingFromTo _removeStringStartingFromTo;
        private readonly The _position;

        internal RemoveStringStartingFromToFrom(RemoveStringStartingFromTo removeStringStartingFromTo, The position)
        {
            _removeStringStartingFromTo = removeStringStartingFromTo;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFromToFrom removeStringStartingFromToFrom)
        {
            return removeStringStartingFromToFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFromTo.RemoveStringStartingFrom.RemoveStringStarting.RemoveString.Source
                .RemoveStartingTo(
                    _removeStringStartingFromTo.RemoveStringStartingFrom.RemoveStringStarting.PositionIndex, _removeStringStartingFromTo.RemoveStringStartingFrom.Position,
                    _removeStringStartingFromTo.PositionIndex, _position);
        }
    }
}
