using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToFrom
    {
        private readonly RemoveStringStartingTo _removeStringStartingTo;
        private readonly The _position;

        internal RemoveStringStartingToFrom(RemoveStringStartingTo removeStringStartingTo, The position)
        {
            _removeStringStartingTo = removeStringStartingTo;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingToFrom removeStringStartingToFrom)
        {
            return removeStringStartingToFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingTo.RemoveStringStarting.RemoveString.Source
                .RemoveStartingTo(_removeStringStartingTo.RemoveStringStarting.PositionIndex, The.Beginning, _removeStringStartingTo.PositionIndex, _position);
        }
    }
}
