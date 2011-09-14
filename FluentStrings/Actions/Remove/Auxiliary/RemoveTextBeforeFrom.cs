using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextBeforeFrom
    {
        private readonly RemoveTextBefore _source;
        private readonly The _position;

        internal RemoveTextBeforeFrom(RemoveTextBefore source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(RemoveTextBeforeFrom removeTextBeforeFrom)
        {
            return removeTextBeforeFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
