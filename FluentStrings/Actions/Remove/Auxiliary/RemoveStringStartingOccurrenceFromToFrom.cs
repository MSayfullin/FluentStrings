using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFromToFrom
    {
        private readonly RemoveStringStartingOccurrenceFromTo _source;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceFromToFrom(RemoveStringStartingOccurrenceFromTo source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFromToFrom removeStringStartingOccurrenceFromToFrom)
        {
            return removeStringStartingOccurrenceFromToFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
