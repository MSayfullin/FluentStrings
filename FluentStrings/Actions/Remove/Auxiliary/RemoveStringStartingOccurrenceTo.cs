using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceTo : IPositional
    {
        private readonly RemoveStringStartingOccurrence _removeStringStartingOccurrence;
        private readonly int _positionIndex;
        private The _position;

        internal RemoveStringStartingOccurrenceTo(RemoveStringStartingOccurrence removeStringStartingOccurrence, int positionIndex)
        {
            _removeStringStartingOccurrence = removeStringStartingOccurrence;
            _positionIndex = positionIndex;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceTo removeStringStartingOccurrenceTo)
        {
            return removeStringStartingOccurrenceTo.ToString();
        }

        public override string ToString()
        {
            if (_removeStringStartingOccurrence.OccurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            if (_positionIndex < 0)
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");

            return _removeStringStartingOccurrence.RemoveString.Source.Remove(_removeStringStartingOccurrence.Marker,
                (s, m) =>
                {
                    var index = s.IndexOf(
                        _removeStringStartingOccurrence.OccurrenceCount, m,
                        _removeStringStartingOccurrence.IgnoreCase, _removeStringStartingOccurrence.Position);

                    if (index == null)
                        index = 0;

                    // index is calculated in direction from the beginning
                    return s.RemoveStartingTo(index.Value, The.Beginning, _positionIndex, _position, applyStartCorrection: false);
                },
                (s, m) => String.Empty);
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
