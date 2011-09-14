using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFrom
    {
        private readonly RemoveStringStarting _source;
        private readonly The _position;

        internal RemoveStringStartingFrom(RemoveStringStarting source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFrom removeStringStartingFrom)
        {
            return removeStringStartingFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
