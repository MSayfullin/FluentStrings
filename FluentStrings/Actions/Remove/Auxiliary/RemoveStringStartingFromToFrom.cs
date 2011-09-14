using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromToFrom
    {
        private readonly RemoveStringStartingFromTo _source;
        private readonly The _position;

        internal RemoveStringStartingFromToFrom(RemoveStringStartingFromTo source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFromToFrom removeStringStartingFromToFrom)
        {
            return removeStringStartingFromToFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
