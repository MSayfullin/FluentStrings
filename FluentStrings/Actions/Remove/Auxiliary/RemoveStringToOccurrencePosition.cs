using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrencePosition : ICaseIgnorable, IPositional
    {
        private readonly RemoveString _removeString;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _from;

        internal RemoveStringToOccurrencePosition(RemoveString removeString, The position, int occurrence, string marker)
        {
            _removeString = removeString;
            _position = position;
            _occurrenceCount = occurrence;
            _marker = marker;
            _ignoreCase = false;
            _from = The.Beginning;
        }

        public static implicit operator string(RemoveStringToOccurrencePosition removeStringToOccurrencePosition)
        {
            return removeStringToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrToPosition(
                _position, _occurrenceCount, _marker,
                _ignoreCase, _from, isStarting: false);
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
