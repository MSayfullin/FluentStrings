using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextAfterFrom
    {
        private readonly RemoveTextAfter _source;
        private readonly The _position;

        internal RemoveTextAfterFrom(RemoveTextAfter source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveTextAfterFrom removeTextAfterFrom)
        {
            return removeTextAfterFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
