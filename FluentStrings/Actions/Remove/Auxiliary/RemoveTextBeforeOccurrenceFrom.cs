using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextBeforeOccurrenceFrom
    {
        private readonly RemoveTextBeforeOccurrence _source;
        private readonly The _position;

        internal RemoveTextBeforeOccurrenceFrom(RemoveTextBeforeOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveTextBeforeOccurrenceFrom removeTextBeforeOccurrenceFrom)
        {
            return removeTextBeforeOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
