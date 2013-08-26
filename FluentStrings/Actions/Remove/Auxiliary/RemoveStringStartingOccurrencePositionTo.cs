using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePositionTo : IPositional
    {
        private readonly RemoveStringStartingOccurrencePosition _removeStringStartingOccurrencePosition;
        private readonly int _positionIndex;
        private The _position;

        internal RemoveStringStartingOccurrencePositionTo(RemoveStringStartingOccurrencePosition removeStringStartingOccurrencePosition, int position)
        {
            _removeStringStartingOccurrencePosition = removeStringStartingOccurrencePosition;
            _positionIndex = position;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingOccurrencePositionTo removeStringStartingOccurrencePositionTo)
        {
            return removeStringStartingOccurrencePositionTo.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
