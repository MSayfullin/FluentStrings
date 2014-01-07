using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrencePosition : ICaseIgnorable, IPositional
    {
        private readonly RemoveStringStarting _removeStringStarting;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _from;

        internal RemoveStringStartingToOccurrencePosition(RemoveStringStarting removeStringStarting, The position, int occurrenceCount, string marker)
        {
            _removeStringStarting = removeStringStarting;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
            _ignoreCase = false;
            _from = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingToOccurrencePosition removeStringStartingToOccurrencePosition)
        {
            return removeStringStartingToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            if (_occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            switch (_position)
            {
                case The.StartOf:
                case The.EndOf:
                    break;
                case The.Beginning:
                case The.End:
                default:
                    throw new ArgumentOutOfRangeException(
                        "position", "Only StartOf and EndOf positions are supported by Remove().Starting().To() method");
            }

            if (_occurrenceCount == 0)
                return _removeStringStarting;

            return _removeStringStarting.RemoveString.Source.Remove(_marker,
                (s, m) =>
                {
                    var index = s.IndexOf(_position, _occurrenceCount, m, _ignoreCase, _from);

                    if (index == null || index >= s.Length)
                        return _removeStringStarting;

                    // index is calculated in direction from the beginning
                    return s.RemoveStartingTo(
                        _removeStringStarting.PositionIndex, _removeStringStarting.Position,
                        index.Value, The.Beginning,
                        applyCorrection: false);
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
            _from = position;
        }

        #endregion
    }
}
