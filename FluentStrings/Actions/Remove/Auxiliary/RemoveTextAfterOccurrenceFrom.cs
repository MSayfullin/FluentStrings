using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextAfterOccurrenceFrom
    {
        private readonly RemoveTextAfterOccurrence _source;
        private readonly The _position;

        internal RemoveTextAfterOccurrenceFrom(RemoveTextAfterOccurrence source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveTextAfterOccurrenceFrom removeTextAfterOccurrenceFrom)
        {
            return removeTextAfterOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
