using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueBeforeFrom
    {
        private readonly RemoveValueBefore _removeValueBefore;
        private readonly The _position;

        internal RemoveValueBeforeFrom(RemoveValueBefore removeValueBefore, The position)
        {
            _removeValueBefore = removeValueBefore;
            _position = position;
        }

        public static implicit operator string(RemoveValueBeforeFrom removeValueBeforeFrom)
        {
            return removeValueBeforeFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
