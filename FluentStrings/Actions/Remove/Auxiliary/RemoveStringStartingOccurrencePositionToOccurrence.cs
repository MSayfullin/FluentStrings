using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePositionToOccurrence : ICaseIgnorable, IPositional
    {
        private readonly RemoveStringStartingOccurrencePosition _removeStringStartingOccurrencePosition;
        private readonly int _occurrence;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal RemoveStringStartingOccurrencePositionToOccurrence(RemoveStringStartingOccurrencePosition removeStringStartingOccurrencePosition, int occurrence, string marker)
        {
            _removeStringStartingOccurrencePosition = removeStringStartingOccurrencePosition;
            _occurrence = occurrence;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingOccurrencePositionToOccurrence removeStringStartingOccurrencePositionToOccurrence)
        {
            return removeStringStartingOccurrencePositionToOccurrence.ToString();
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
            _position = position;
        }

        #endregion
    }
}
