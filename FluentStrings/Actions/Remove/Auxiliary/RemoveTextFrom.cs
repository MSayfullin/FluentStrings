using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextFrom
    {
        private readonly RemoveText _source;
        private readonly The _position;

        internal RemoveTextFrom(RemoveText source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveTextFrom removeTextFrom)
        {
            return removeTextFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
