using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveCharsFrom
    {
        private readonly string _source;
        private readonly The _position;

        internal RemoveCharsFrom(string source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveCharsFrom removeCharsFrom)
        {
            return removeCharsFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
