using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePosition : ICaseIgnorable, IPositional
    {
        private readonly RemoveString _removeString;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _from;

        internal RemoveStringStartingOccurrencePosition(RemoveString removeString, The position, int occurrenceCount, string marker)
        {
            _removeString = removeString;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
            _ignoreCase = false;
            _from = The.Beginning;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal The Position { get { return _position; } }
        internal int OccurrenceCount { get { return _occurrenceCount; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringStartingOccurrencePosition removeStringStartingOccurrencePosition)
        {
            return removeStringStartingOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrToPosition(
                _position, _occurrenceCount, _marker,
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
