using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceToFrom
    {
        private readonly RemoveStringStartingOccurrenceTo _source;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceToFrom(RemoveStringStartingOccurrenceTo source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceToFrom removeStringStartingOccurrenceToFrom)
        {
            return removeStringStartingOccurrenceToFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
