using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrencePositionIgnoringCase
    {
        private readonly RemoveStringToFirstOccurrencePosition _removeStringToFirstOccurrencePosition;

        internal RemoveStringToFirstOccurrencePositionIgnoringCase(RemoveStringToFirstOccurrencePosition removeStringToFirstOccurrencePosition)
        {
            _removeStringToFirstOccurrencePosition = removeStringToFirstOccurrencePosition;
        }

        internal RemoveStringToFirstOccurrencePosition RemoveStringToFirstOccurrencePosition { get { return _removeStringToFirstOccurrencePosition; } }

        public static implicit operator string(RemoveStringToFirstOccurrencePositionIgnoringCase removeStringToFirstOccurrencePositionIgnoringCase)
        {
            return removeStringToFirstOccurrencePositionIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringToFirstOccurrencePosition.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringToFirstOccurrencePosition.Position,
                1, _removeStringToFirstOccurrencePosition.Marker,
                ignoreCase: true, from: The.Beginning, isStarting: false);
        }
    }
}
