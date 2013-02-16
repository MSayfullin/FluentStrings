using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFrom
    {
        private readonly RemoveStringTo _source;
        private readonly The _position;

        internal RemoveStringToFrom(RemoveStringTo source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFrom removeStringToFrom)
        {
            return removeStringToFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
