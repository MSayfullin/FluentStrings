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
            if (_removeStringStartingOccurrencePosition.OccurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            if (_positionIndex < 0)
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");

            switch (_removeStringStartingOccurrencePosition.Position)
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

            return _removeStringStartingOccurrencePosition.RemoveString.Source.Remove(_removeStringStartingOccurrencePosition.Marker,
                (s, m) =>
                {
                    var index = s.IndexOf(
                        _removeStringStartingOccurrencePosition.Position, _removeStringStartingOccurrencePosition.OccurrenceCount, m,
                        _removeStringStartingOccurrencePosition.IgnoreCase, _removeStringStartingOccurrencePosition.From);

                    if (index == null || index >= s.Length)
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
