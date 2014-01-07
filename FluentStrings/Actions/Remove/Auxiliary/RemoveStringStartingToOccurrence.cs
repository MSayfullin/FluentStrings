using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrence : ICaseIgnorable, IPositional
    {
        private readonly RemoveStringStarting _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal RemoveStringStartingToOccurrence(RemoveStringStarting source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingToOccurrence removeStringStartingToOccurrence)
        {
            return removeStringStartingToOccurrence.ToString();
        }

        public override string ToString()
        {
            if (_occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            if (_occurrenceCount == 0)
                return _source;

            return _source.RemoveString.Source.Remove(_marker,
                (s, m) =>
                {
                    var index = s.IndexOf(_occurrenceCount, m, _ignoreCase, _position);

                    if (index == null)
                        return _source;

                    // index is calculated in direction from the beginning
                    return s.RemoveStartingTo(_source.PositionIndex, _source.Position, index.Value, The.Beginning, applyCorrection: false);
                },
                (s, m) => String.Empty);
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
