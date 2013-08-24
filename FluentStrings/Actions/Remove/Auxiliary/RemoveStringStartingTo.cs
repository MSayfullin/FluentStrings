using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingTo : IPositional
    {
        private readonly RemoveStringStarting _removeStringStarting;
        private readonly int _positionIndex;
        private The _position;

        internal RemoveStringStartingTo(RemoveStringStarting removeStringStarting, int positionIndex)
        {
            _removeStringStarting = removeStringStarting;
            _positionIndex = positionIndex;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingTo removeStringStartingTo)
        {
            return removeStringStartingTo.ToString();
        }

        public override string ToString()
        {
            return _removeStringStarting.RemoveString.Source.RemoveStartingTo(
                _removeStringStarting.PositionIndex, _removeStringStarting.Position, _positionIndex, _position);
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
