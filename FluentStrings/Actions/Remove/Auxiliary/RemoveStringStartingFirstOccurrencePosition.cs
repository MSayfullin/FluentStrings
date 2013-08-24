using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrencePosition : ICaseIgnorable, IPositional
    {
        private readonly RemoveString _removeString;
        private readonly The _position;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _from;

        internal RemoveStringStartingFirstOccurrencePosition(RemoveString removeString, The position, string marker)
        {
            _removeString = removeString;
            _position = position;
            _marker = marker;
            _ignoreCase = false;
            _from = The.Beginning;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal The Position { get { return _position; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringStartingFirstOccurrencePosition removeStringStartingFirstOccurrencePosition)
        {
            return removeStringStartingFirstOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrToPosition(
                _position, 1, _marker,
                _ignoreCase, _from, isStarting: true);
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
