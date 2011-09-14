using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToFrom
    {
        private readonly RemoveStringStartingTo _source;
        private readonly The _position;

        internal RemoveStringStartingToFrom(RemoveStringStartingTo source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingToFrom removeStringStartingToFrom)
        {
            return removeStringStartingToFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
