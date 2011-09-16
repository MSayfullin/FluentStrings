using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrenceFrom
    {
        private readonly RemoveStringToOccurrence _source;
        private readonly The _position;

        internal RemoveStringToOccurrenceFrom(RemoveStringToOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringToOccurrenceFrom removeStringToOccurrenceFrom)
        {
            return removeStringToOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
