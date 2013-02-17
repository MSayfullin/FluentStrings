using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueAfterFrom
    {
        private readonly RemoveValueAfter _removeValueAfter;
        private readonly The _position;

        internal RemoveValueAfterFrom(RemoveValueAfter removeValueAfter, The position)
        {
            _removeValueAfter = removeValueAfter;
            _position = position;
        }

        public static implicit operator string(RemoveValueAfterFrom removeValueAfterFrom)
        {
            return removeValueAfterFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
