using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePositionToOccurrencePosition : ICaseIgnorable, IPositional
    {
        private readonly RemoveStringStartingOccurrencePosition _removeStringStartingOccurrencePosition;
        private readonly The _position;
        private readonly int _occurrence;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _from;

        internal RemoveStringStartingOccurrencePositionToOccurrencePosition(RemoveStringStartingOccurrencePosition removeStringStartingOccurrencePosition, The position, int occurrence, string marker)
        {
            _removeStringStartingOccurrencePosition = removeStringStartingOccurrencePosition;
            _position = position;
            _occurrence = occurrence;
            _marker = marker;
            _ignoreCase = false;
            _from = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingOccurrencePositionToOccurrencePosition removeStringStartingOccurrencePositionToOccurrencePosition)
        {
            return removeStringStartingOccurrencePositionToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        #region ICaseIgnorable Members

        void ICaseIgnorable.IgnoreCase()
        {
            _ignoreCase = true;
        }

        #endregion

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _from = position;
        }

        #endregion
    }
}
